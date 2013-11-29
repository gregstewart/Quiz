using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Quiz.Models;

namespace Quiz.Tests.Models
{
    [TestClass]
    public class QuizCreatorTest
    {
        [TestMethod]
        public void TestGenerateQuiz()
        {
            QuizCreator quizCreator = new QuizCreator();
            var questionsAndAnswers = quizCreator.Generate();

            Assert.IsInstanceOfType(questionsAndAnswers, typeof(QuestionBag));
            
            var questions = questionsAndAnswers.GetQuestions();

            Assert.IsTrue(questions.Count() > 0);

            QuizQuestionAndAnswers firstQuizQuestionAndAnswers = (QuizQuestionAndAnswers) questions.ElementAt(0);
            var answers = firstQuizQuestionAndAnswers.GetAnswers();

            Assert.IsTrue(answers.Count() > 0);

        }

    }
}
