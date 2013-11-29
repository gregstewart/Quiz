using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Quiz.Models
{
    public class QuestionBag
    {
        private IEnumerable<QuizQuestionAndAnswers> _questions;

        public QuestionBag(IEnumerable<QuizQuestionAndAnswers> questions)
        {
            _questions = questions;
        }

        public IEnumerable<QuizQuestionAndAnswers> GetQuestions()
        {
            return _questions;
        }
    }
}