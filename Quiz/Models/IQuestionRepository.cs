using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz.Models
{
    interface IQuestionRepository
    {
        IEnumerable<Question> GetAll();
        Question Get(int id);
        Question Add(Question item);
        void Remove(int id);
        bool Update(Question item);
    }
}
