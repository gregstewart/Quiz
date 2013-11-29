using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Quiz.Models
{
    public class QuizCreator
    {
        private IEnumerable<QuizQuestionAndAnswers> _questions = new List<QuizQuestionAndAnswers>();
        private QuestionSelector _questionSelector;

        public QuizCreator()
        {
            _questionSelector = new QuestionSelector();
        }

        public QuestionBag Generate()
        {
            _questions = _questionSelector.Select();

            QuestionBag questionBag = new QuestionBag(_questions);

            return questionBag;
        }
    }
}