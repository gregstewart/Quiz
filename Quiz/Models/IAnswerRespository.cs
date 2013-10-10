using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz.Models
{
    interface IAnswerRespository
    {
        IEnumerable<Answer> GetAll();
        Answer Get(int id);
        Answer Add(Answer item);
        void Remove(int id);
        bool Update(Answer item);
    }
}
