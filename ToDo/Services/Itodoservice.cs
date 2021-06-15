using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ToDo.Models;

namespace ToDo.Services
{
    interface Itodoservice
    {
        public List<work> Create([FromBody] work Newtodo);
        public List<work> Get();
        public work GetById(int id);
    }
}
