using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ToDo.Models
{
    public class ServiceResponse<T>
    {
        public T Data { get; set; }
        public bool status { get; set; } = true;
        public string Message { get; set; } = null;
    }
}
