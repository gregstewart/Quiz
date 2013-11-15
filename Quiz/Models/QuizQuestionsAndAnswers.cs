using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Quiz.Models
{
    public class QuizQuestionsAndAnswers
    {
        private IEnumerable<Question> _questions;

        public QuizQuestionsAndAnswers(IEnumerable<Question> questions)
        {
            _questions = questions;
        }

        public IEnumerable<Question> GetQuestions()
        {
            return _questions;
        }
    }
}