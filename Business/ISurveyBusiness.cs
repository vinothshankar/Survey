using Survey.Entities;
using Survey.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Survey.Business
{
    public interface ISurveyBusiness
    {
        public List<Surveys> FetchAllSurveys();
        public List<Questions> FetchAllQuestionBySurveyId(long surveyId);
        public void SaveSurveyResult(List<AnswersVM> answersVMs);
    }
}
