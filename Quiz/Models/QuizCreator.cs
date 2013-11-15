using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Quiz.Models
{
    public class QuizCreator
    {
        private IEnumerable<Question> _questions = new List<Question>();
        private QuestionPicker _questionPicker;

        public QuizCreator()
        {
            _questionPicker = new QuestionPicker();
        }

        public QuizQuestionsAndAnswers Generate()
        {
            _questions = _questionPicker.GetQuestions();

            QuizQuestionsAndAnswers quizQuestionsAndAnswers = new QuizQuestionsAndAnswers(_questions);

            return quizQuestionsAndAnswers;
        }
    }
}