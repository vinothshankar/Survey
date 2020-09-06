using Microsoft.EntityFrameworkCore;
using Survey.Entities;
using Survey.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Survey.Business
{
    public class SurveyBusiness : ISurveyBusiness
    {
        private SurveyContext _dbContext;

        public SurveyBusiness(DbContext dbContext)
        {
            _dbContext = dbContext as SurveyContext;
        }

        public List<Questions> FetchAllQuestionBySurveyId(long surveyId)
        {
            List<Questions> questions = new List<Questions>();
            try
            {
                questions = _dbContext.Questions.Where(e => e.SurveyId == surveyId).ToList();
                if (questions.Count > 0)
                {
                    List<long> questionIds = questions.Select(e => e.QuestionId).ToList();
                    var options = _dbContext.Options.Where(e => questionIds.Contains(e.QuestionId)).ToList();
                    foreach (var question in questions)
                    {
                        var optionByQuestionId = options.Where(e => e.QuestionId == question.QuestionId).ToList();
                        question.options = optionByQuestionId;
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return questions;
        }

        public List<Surveys> FetchAllSurveys()
        {
            List<Surveys> surveys = new List<Surveys>();
            try
            {
                surveys = _dbContext.Surveys.ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return surveys;
        }

        public void SaveSurveyResult(List<AnswersVM> answersVMs)
        {
            try
            {
                List<Answers> answers = new List<Answers>();
                _dbContext.Database.BeginTransaction();
                answersVMs.ForEach(e =>
                {
                    Answers answer = new Answers()
                    {
                        OptionId = e.OptionId,
                        QuestionId = e.QuestionID,
                        UserNm = Guid.NewGuid().ToString()
                    };
                    answers.Add(answer);
                });
                _dbContext.Answers.AddRange(answers);
                _dbContext.SaveChanges();
                _dbContext.Database.CommitTransaction();
            }
            catch (Exception ex)
            {

                _dbContext.Database.RollbackTransaction();
                throw ex;
            }
        }
    }
}
