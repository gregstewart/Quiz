using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Quiz.Models;

namespace Quiz.Controllers
{
    public class QuestionController : ApiController
    {
        static readonly IQuestionRepository repository = new QuestionRepository();

        // GET api/<controller>
        public IEnumerable<Question> Get()
        {
            return repository.GetAll();
        }

        // GET api/<controller>/5
        public Question Get(int id)
        {
            return repository.Get(id);
        }

        // POST api/<controller>
        public Question Post([FromBody]string value)
        {
            Question questionBag = new Question { QuestionString = value };
            return repository.Add(questionBag);
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }
    }
}