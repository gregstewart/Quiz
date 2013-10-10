using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Web.Http;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Quiz;
using Quiz.Controllers;
using Quiz.Models;

namespace Quiz.Tests.Controllers
{
    [TestClass]
    public class AnswerControllerTest
    {
        [TestMethod]
        public void GetAnswersByQuestionId()
        {
            AnswerController controller = new AnswerController();

            IEnumerable<Answer> result = controller.GetByQuestion(5);

            Assert.IsTrue(result.Any());
            Assert.AreEqual(result.First().AnswerString, "Ultraxion");
        }

        [TestMethod]
        public void GetAnswersByQuestionIdReturnsMultipleResult()
        {
            AnswerController controller = new AnswerController();

            IEnumerable<Answer> result = controller.GetByQuestion(7);

            Assert.AreEqual(result.Count(), 2);
            Assert.AreEqual(result.First().AnswerString, "Blackhorn");
            Assert.AreEqual(result.ElementAt(1).AnswerString, "Warmaster Blackhorn");
        }

        [TestMethod]
        public void Get()
        {
            AnswerController controller = new AnswerController();

            IEnumerable<Answer> result = controller.Get();

            Answer firstAnswer = result.ElementAt(0);
            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(8, result.Count());

            Assert.AreEqual("Alizabal", firstAnswer.AnswerString);
            Assert.AreEqual(1, firstAnswer.Id);
            Assert.AreEqual(1, firstAnswer.QuestionId);
        }

        [TestMethod]
        public void GetById()
        {
            AnswerController controller = new AnswerController();

            Answer result = controller.Get(6);

            Assert.IsNotNull(result);
            Assert.AreEqual("Yor'sahj", result.AnswerString);
            Assert.AreEqual(6, result.Id);
            Assert.AreEqual(6, result.QuestionId);
        }
    }

}
