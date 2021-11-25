using ClassLibraryEmp;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;
using System;
using System.Collections;
using System.Collections.Generic;
using static ClassLibraryEmp.Repos;

namespace WebApplication7.Controllers
{

    [Route("/[controller]")]
    public class EmployeeController: ControllerBase
    {
        private List<Employee> emps = new List<Employee>() { new Employee(){


               Name="Elefthrios", Surname="Gianoudakis", Salary=150, StartDate=Convert.ToDateTime("01/08/2008"), EndDate=Convert.ToDateTime("01/08/2013")}
            
        };

        
        
        
        

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(emps);
        }

        //[HttpGet]
        //public ActionResult GetAll()
        //{
        //    List<Employee>allemps = GetEmps();
        //    return Ok(allemps);
        //}




    }
}
