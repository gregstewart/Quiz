using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Quiz.Controllers;

namespace Quiz.Models
{
    public class QuestionRepository : IQuestionRepository
    {
        private List<Question> _questions = new List<Question>();
        private int _nextId = 1;

        public QuestionRepository()
        {
            Add(new Question { QuestionString = "What boss was added in Baradin hold in 4.3?" });
            Add(new Question { QuestionString = "Who must you defend in Hour of Twilight dungeon?" });
            Add(new Question { QuestionString = "What boss drops Shoulder token?(Normal and HC mode)" });
            Add(new Question { QuestionString = "What boss drops Glove token?(Normal and HC mode)" });
            Add(new Question { QuestionString = "What boss drops Chest token?(Normal and HC mode)" });
            Add(new Question { QuestionString = "What boss drops Pants token?(Normal and HC mode)" });
            Add(new Question { QuestionString = "What boss drops Head token?(Normal and HC mode)" });
        }
        public IEnumerable<Question> GetAll()
        {
            return _questions;
        }

        public Question Get(int id)
        {
            return _questions.Find(p => p.Id == id);
        }

        public Question Add(Question item)
        {
            if (item == null)
            {
                throw new ArgumentNullException("item");
            }
            item.Id = _nextId++;
            _questions.Add(item);

            return item;
        }

        public void Remove(int id)
        {
            throw new NotImplementedException();
        }

        public bool Update(Question item)
        {
            throw new NotImplementedException();
        }
    }
}