using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Quiz.Models
{
    public class AnswerRepository : IAnswerRespository
    {
        private List<Answer> _answers = new List<Answer>();
        private int _nextId = 1;

        public AnswerRepository()
        {
            Add(new Answer { AnswerString = "Alizabal", QuestionId = 1});
            Add(new Answer { AnswerString = "Thrall", QuestionId = 2 });
            Add(new Answer { AnswerString = "Hagara", QuestionId = 3 });
            Add(new Answer { AnswerString = "Zon'ozz", QuestionId = 4 });
            Add(new Answer { AnswerString = "Ultraxion", QuestionId = 5 });
            Add(new Answer { AnswerString = "Yor'sahj", QuestionId = 6 });
            Add(new Answer { AnswerString = "Blackhorn", QuestionId = 7 });
            Add(new Answer { AnswerString = "Warmaster Blackhorn", QuestionId = 7 });
        }

        public IEnumerable<Answer> GetAll()
        {
            return _answers;
        }

        public Answer Get(int id)
        {
            return _answers.Find(p => p.Id == id);
        }

        public Answer Add(Answer item)
        {
            if (item == null)
            {
                throw new ArgumentNullException("item");
            }
            item.Id = _nextId++;
            _answers.Add(item);

            return item;
        }

        public void Remove(int id)
        {
            throw new NotImplementedException();
        }

        public bool Update(Answer item)
        {
            throw new NotImplementedException();
        }
    }
}