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
        public async Task<ServiceResponse<List<work>>> Create( work Newtodo)
        {
            ServiceResponse<List<work>> s = new ServiceResponse<List<work>>();
            todo.Add(Newtodo);
            s.Data = todo;
            return s;
        }

        public async Task<ServiceResponse<List<work>>> Get()
        {
            ServiceResponse<List<work>> s = new ServiceResponse<List<work>>();
            s.Data = todo;
            return s;
        }

        public async Task<ServiceResponse<work>> GetById(int id)
        {
            ServiceResponse<work> s = new ServiceResponse<work>();
            s.Data =  todo.FirstOrDefault(t => t.Id == id);
            return s;
        }

        public async Task<ServiceResponse<work>> Update(work updated)
        {
            ServiceResponse<work> s = new ServiceResponse<work>();
            try 
            { 
                    work w= todo.FirstOrDefault(c => c.Id == updated.Id);
                if (w != null)
                {
                    w.Name = updated.Name;
                    w.complete = updated.complete;
                    s.Data = w;
                }
                else 
                {
                    throw new Exception();
                }
            }
            catch(Exception ex)
            {
                s.status = false;
                s.Message = ex.Message;

            }
            return s;
        }
        public async Task<ServiceResponse<work>> Delete(int id)
        {
            ServiceResponse<work> s = new ServiceResponse<work>();
            try 
            {
                work w = todo.Find(c => c.Id == id);
                if (w != null)
                {
                    todo.Remove(w);
                }
                else 
                {
                    throw new Exception(); 
                }
            }
            catch(Exception ex)
            {
                s.status = false;
                s.Message = ex.Message;
            }
            return s;
        }
    }
}
