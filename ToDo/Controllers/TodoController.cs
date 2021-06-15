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
        
       
        [HttpPost("Create")]
        public ActionResult<List<work>> Create([FromBody] work Newtodo)
        {
            
            //return Ok(todo);
        }
        [HttpGet("Read")]
        public ActionResult<work> Get()
        {
            //return Ok(todo[0]);
        }
        [HttpGet("Read/{id}")]
        public ActionResult<work> GetById(int id)
        {
            //return Ok(todo.FirstOrDefault(t=>t.Id==id));
        }

    }
}
