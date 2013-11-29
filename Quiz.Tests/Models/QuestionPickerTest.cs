using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Quiz.Models;

namespace Quiz.Tests.Models
{
    [TestClass]
    public class QuestionPickerTest
    {
        [TestMethod]
        public void GetQuestions()
        {
            QuestionSelector questionSelector = new QuestionSelector();
            IEnumerable<QuizQuestionAndAnswers> questions = questionSelector.GetQuestions();

            Assert.IsTrue(questions.Count() > 0);
        }

        [TestMethod]
        public void GetAnswers()
        {
            QuestionSelector questionSelector = new QuestionSelector();
            IEnumerable<Answer> answers = questionSelector.GetAnswersForSelectedQuestions(1);

            Assert.IsTrue(answers.Count() > 0);
        }

        [TestMethod]
        public void Select()
        {
            QuestionSelector questionSelector = new QuestionSelector();

            IEnumerable<QuizQuestionAndAnswers> questions = questionSelector.Select();

            Assert.IsTrue(questions.Count() > 0);

            IEnumerable<Answer> answersForQuestion = questions.ElementAt(0).GetAnswers();

            Assert.IsTrue(answersForQuestion.Count() > 0);
        }
    }
}
