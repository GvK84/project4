using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Formatting;
using System.Threading.Tasks;
using System.Web;
using ClassLibraryEmp;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;
using static ClassLibraryEmp.Repos;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApplication7.Controllers
{
    [Route("/[controller]")]
    public class AllEmployeesController : ControllerBase
    {

        private List<Employee> GetEmps()
        {
            Repos rep = new Repos();
            List<Employee> allemps = new List<Employee>();
            foreach (Employee emp in rep.GetAllEmployees())
            {
                allemps.Add(emp);
            }
            return allemps;

        }


        [HttpGet]
        public IActionResult Get()
        {
            List<Employee> allemps = GetEmps();
            return Ok(allemps);
        }


    }
}
