using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ToDo.Models;
using ToDo.Services;

namespace ToDo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TodoController : ControllerBase
    {
        private readonly Itodoservice _todoservice;
        public TodoController(Itodoservice todoserve)
        {
           _todoservice = todoserve;
        }
        
        [HttpPost("Create")]
        public async Task<ActionResult<List<work>>> Create([FromBody] work Newtodo)
        {

            return Ok(await _todoservice.Create(Newtodo));
        }
        [HttpGet("Read")]
        public async Task<ActionResult<work>> Get()
        {
            return Ok(await _todoservice.Get());
        }
        [HttpGet("Read/{id}")]
        public async Task<ActionResult<work>> GetById(int id)
        {
            return Ok(await _todoservice.GetById(id));
        }
        [HttpPut("Update")]
        public async Task<ActionResult<work>> Put([FromBody]work updated)
        {
            return Ok(await _todoservice.Update(updated));
        }
        [HttpDelete("Delete/{id}")]
        public async Task<ActionResult<ServiceResponse<work>>> Delete(int id)
        {
            return Ok(await _todoservice.Delete(id));
        }

    }
}
