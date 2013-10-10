using System;
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
    public class QuestionControllerTest
    {
        [TestMethod]
        public void Get()
        {
            // Arrange
            QuestionController controller = new QuestionController();

            // Act
            IEnumerable<Question> result = controller.Get();
            Question firstQuestion = result.ElementAt(0);
            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(7, result.Count());

            Assert.AreEqual("What boss was added in Baradin hold in 4.3?", firstQuestion.QuestionString);
            Assert.AreEqual(1, firstQuestion.Id);
        }

        [TestMethod]
        public void GetById()
        {
            // Arrange
            QuestionController controller = new QuestionController();

            // Act
            Question result = controller.Get(5);

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual("What boss drops Chest token?(Normal and HC mode)", result.QuestionString);

        }

        [TestMethod]
        public void Post()
        {
            String question = "Is this a test question";
            
            // Arrange
            QuestionController controller = new QuestionController();

            // Act
            Question result = controller.Post(question);

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(question, result.QuestionString);
            Assert.AreEqual(8, result.Id);

        }
//
//        [TestMethod]
//        public void Put()
//        {
//            // Arrange
//            QuestionController controller = new QuestionController();
//
//            // Act
//            controller.Put(5, "value");
//
//            // Assert
//        }
//
//        [TestMethod]
//        public void Delete()
//        {
//            // Arrange
//            QuestionController controller = new QuestionController();
//
//            // Act
//            controller.Delete(5);
//
//            // Assert
//        }
    }
}
