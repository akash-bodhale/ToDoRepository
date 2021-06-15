using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ToDo.Models;

namespace ToDo.Services
{
    public class TodoService : Itodoservice
    {
        private List<work> todo = new List<work>();
        public TodoService()
        {
            todo.Add(new work { Id = 1, Name = "nazar", complete = false });
        }
        public List<work> Create( work Newtodo)
        {
            todo.Add(Newtodo);
            return todo;
        }

        public List<work> Get()
        {
            return todo;
        }

        public work GetById(int id)
        {
            return todo.FirstOrDefault(t => t.Id == id);
        }
    }
}
