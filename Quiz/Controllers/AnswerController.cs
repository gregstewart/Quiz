using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Quiz.Models;

namespace Quiz.Controllers
{
    public class AnswerController : ApiController
    {
        static readonly IAnswerRespository repository = new AnswerRepository();
        
        // GET api/<controller>
        public IEnumerable<Answer> Get()
        {
            return repository.GetAll();
        }

        // GET api/<controller>/5
        public Answer Get(int id)
        {
            return repository.Get(id);
        }

        // POST api/<controller>
        public void Post([FromBody]string value)
        {
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }

        // GET api/<controller>/?question=5
        public IEnumerable<Answer> GetByQuestion(int question)
        {
            return repository.GetAll().Where(p => int.Equals(p.QuestionId, question));
        }
    }
}