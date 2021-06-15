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
        public Task<ServiceResponse<List<work>>> Create( work Newtodo);
        public Task<ServiceResponse<List<work>>> Get();
        public Task<ServiceResponse<work>> GetById(int id);
        public Task<ServiceResponse<work>> Update(work updated);
    }
}
