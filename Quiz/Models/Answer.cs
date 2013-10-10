using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Quiz.Models
{
    public class Answer
    {
        public int Id { get; set; }
        public int QuestionId { get; set;  }
        public String AnswerString { get; set; }
    }
}