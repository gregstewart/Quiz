using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Quiz.Models
{
    public class QuizQuestionsAndAnswers
    {
        private IEnumerable<QuestionBag> _questions;

        public QuizQuestionsAndAnswers(IEnumerable<QuestionBag> questions)
        {
            _questions = questions;
        }

        public IEnumerable<QuestionBag> GetQuestions()
        {
            return _questions;
        }
    }
}