using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ToDo.Models;

namespace ToDo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TodoController : ControllerBase
    {
        private List<work> todo = new List<work>();
        public TodoController()
        {
            todo.Add(new work {Id=1,Name="nazar",complete=false});
        }
        [HttpPost("Create")]
        public ActionResult<List<work>> Create([FromBody] work Newtodo)
        {
            todo.Add(Newtodo);
            return Ok(todo);
        }
        [HttpGet("Read")]
        public ActionResult<work> Get()
        {
            return Ok(todo[0]);
        }
        [HttpGet("Read/{id}")]
        public ActionResult<work> GetById(int id)
        {
            return Ok(todo.FirstOrDefault(t=>t.Id==id));
        }

    }
}
