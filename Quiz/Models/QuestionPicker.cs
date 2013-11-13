using System.Collections.Generic;

namespace Quiz.Models
{
    public class QuestionPicker
    {
        public IEnumerable<Question> GetQuestions()
        {
            QuestionRepository questionsRepository = new QuestionRepository();
            return questionsRepository.GetAll();
        }
    }
}