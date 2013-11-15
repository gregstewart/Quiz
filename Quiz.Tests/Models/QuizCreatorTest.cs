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

            Assert.IsInstanceOfType(questionsAndAnswers, typeof(QuizQuestionsAndAnswers));
            
            var questions = questionsAndAnswers.GetQuestions();

            Assert.IsTrue(questions.Count() > 0);

            Question firstQuestion = questions.ElementAt(0);
            var answers = firstQuestion.GetAnswers();

            Assert.IsTrue(answers.Count() > 0);

        }

    }
}
