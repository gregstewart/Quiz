using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Quiz.Models
{
    public class QuizCreator
    {
        private IEnumerable<QuestionBag> _questions = new List<QuestionBag>();
        private QuestionSelector _questionSelector;

        public QuizCreator()
        {
            _questionSelector = new QuestionSelector();
        }

        public QuizQuestionsAndAnswers Generate()
        {
            _questions = _questionSelector.Select();

            QuizQuestionsAndAnswers quizQuestionsAndAnswers = new QuizQuestionsAndAnswers(_questions);

            return quizQuestionsAndAnswers;
        }
    }
}