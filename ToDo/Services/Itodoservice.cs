using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ToDo.Models;

namespace ToDo.Services
{
   public  interface Itodoservice
    {
        public Task<List<work>> Create( work Newtodo);
        public Task<List<work>> Get();
        public Task<work> GetById(int id);
        public Task<work> Update(work updated);
    }
}
