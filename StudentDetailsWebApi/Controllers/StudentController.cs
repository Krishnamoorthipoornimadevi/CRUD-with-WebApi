using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dapper;
using DapperDataAccessLayer;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace StudentDetailsWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        IStudentDetailsRepository obj;
        public StudentController()
        {
            obj = new StudentDetailsRepository();
        }
        // GET: api/<StudentController>
        [HttpGet]
        public IEnumerable<StudentDetails> Get()
        {
            return obj.GetStudentDetailsSP();
        }

        //// GET api/<StudentController>/5
        //[HttpGet("{id}")]
        //public string Get(int id)
        //{
        //    return "value";
        //}

        //// POST api/<StudentController>
        [HttpPost]
        public StudentDetails Post([FromBody] StudentDetails value)
        {
            return obj.InsertSP(value);
        }

        // PUT api/<StudentController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] StudentDetails value)
        {
            obj.UpdateSP(id, value);
        }

        // DELETE api/<StudentController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            obj.DeleteStudentDetailsSP(id);
        }
    }
}
