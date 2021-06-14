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
        private static List<work> task = new List<work>(); 
        [HttpGet("Read")]
        public ActionResult<work> Get()
        {
            return Ok(task[0]);
        }

    }
}
