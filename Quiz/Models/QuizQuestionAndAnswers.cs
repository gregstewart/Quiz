using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Quiz.Models
{
    public class QuizQuestionAndAnswers
    {
        private IEnumerable<Answer> _answers = null;
        
        public QuizQuestionAndAnswers(int id, string questionString)
        {
            this.Id = id;
            this.QuestionString = questionString;
        }
        
        public int Id { get; set; }
        public String QuestionString { get; set; }

        public IEnumerable<Answer> GetAnswers()
        {
            return _answers;
        }

        public void SetAnswers(IEnumerable<Answer> answers)
        {
            _answers = answers;
        }
    }
}