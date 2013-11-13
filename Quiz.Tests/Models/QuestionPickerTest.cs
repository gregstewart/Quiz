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
            QuestionPicker questionPicker = new QuestionPicker();
            IEnumerable<Question> questions = questionPicker.GetQuestions();

            Assert.IsTrue(questions.Count() > 0);
        }
    }
}
