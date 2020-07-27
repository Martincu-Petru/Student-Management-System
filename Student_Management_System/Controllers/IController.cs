using System;
using System.Collections.Generic;
using System.Text;

namespace Student_Management_System.Controllers
{
    interface IController<T>
    {
        public void Add(T myObject);

        public void Delete(T myObject);

        public void Update(T myObject);

        public List<T> GetAll();
    }
}
