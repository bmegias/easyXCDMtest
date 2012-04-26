using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web.Http;

namespace easyXDMtest.Controllers
{
    public class Employee
    {
        public string Name { get; set; }
        public string Surname { get; set; }
    }

    public class EmployeesController : ApiController
    {
        // GET /api/values
        public IEnumerable<Employee> Get()
        {
            return new[]
                       {
                           new Employee {Name = "Nom1", Surname = "Ape1"}
                           , new Employee {Name = "Nom2", Surname = "Ape2"}
                       };
        }

        //// GET /api/values/5
        //public string Get(int id)
        //{
        //    return "value";
        //}

        //// POST /api/values
        //public void Post(string value)
        //{
        //}

        //// PUT /api/values/5
        //public void Put(int id, string value)
        //{
        //}

        //// DELETE /api/values/5
        //public void Delete(int id)
        //{
        //}
    }
}
