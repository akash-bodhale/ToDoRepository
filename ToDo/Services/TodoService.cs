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
        public async Task<List<work>> Create( work Newtodo)
        {
            todo.Add(Newtodo);
            return todo;
        }

        public async Task<List<work>> Get()
        {
            return todo;
        }

        public async Task<work> GetById(int id)
        {
            return todo.FirstOrDefault(t => t.Id == id);
        }

        public async Task<work> Update(work updated)
        {
            try
            {
                work w = todo.FirstOrDefault(c => c.Id == updated.Id);
                if (w.Id == updated.Id)
                {
                    w.Name = updated.Name;
                    w.complete = updated.complete;
                    return w;
                }
                else 
                {
                    throw null;
                }
            }
            catch (Exception ex)
            {
                throw new NullReferenceException("Null exception");
            }
            
            
        }
    }
}
