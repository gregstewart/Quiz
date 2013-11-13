using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Quiz.Models
{
    public class QuizQuestionsAndAnswers
    {
        private List<Question> _questions;

        public QuizQuestionsAndAnswers(List<Question> questions)
        {
            _questions = questions;
        }

        public IEnumerable<Question> GetQuestions()
        {
            return _questions;
        }
    }
}