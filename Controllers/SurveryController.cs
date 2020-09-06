using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Survey.Business;
using Survey.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Survey.Controllers
{
    public class SurveyController : Controller
    {
        private ISurveyBusiness _surveyBusiness;
        public SurveyController(ISurveyBusiness surveyBusiness)
        {
            _surveyBusiness = surveyBusiness;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult FetchAllSurveys()
        {
            try
            {
                var data = _surveyBusiness.FetchAllSurveys();
                return View("SurveyList", data);
            }
            catch (Exception ex)
            {
                return View("Error", ex.Message);
            }
        }

        [HttpGet]
        public IActionResult FetchAllQuestionsBySurveyId(long surveyId)
        {
            try
            {
                var data = _surveyBusiness.FetchAllQuestionBySurveyId(surveyId);
                return View("Questions", data);
            }
            catch (Exception ex)
            {
                return View("Error", ex.Message);
            }
        }

        [HttpPost]
        public IActionResult SaveResult()
        {

            try
            {
                var formData = Request.Form.Select(e => e.Key.ToString()).FirstOrDefault();
                List<AnswersVM> answersVMs = JsonConvert.DeserializeObject<List<AnswersVM>>(formData);
                _surveyBusiness.SaveSurveyResult(answersVMs);
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                return View("Error", ex.Message);
            }
        }
    }
}
