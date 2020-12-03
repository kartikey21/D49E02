using D49E02.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace D49E02.Controllers
{
    public class empList : Controller
    {
        public IActionResult Index()
        {
            List<Emp> empData = new List<Emp>
            {
                new Emp
                {
                    EmpID=101,
                    EmpName="Mohit",
                    EmpDesignation="Manager",
                    EmpDOJ=new DateTime(month:02,day:29,year:2000)
                },
                new Emp
                {
                    EmpID=102,
                    EmpName="Taneesha",
                    EmpDesignation="Developer",
                    EmpDOJ=new DateTime(month:11,day:03,year:2005)
                },
                new Emp
                {
                    EmpID=105,
                    EmpName="Arpit",
                    EmpDesignation="HR",
                    EmpDOJ=new DateTime(month:12,day:30,year:2016)
                },
                new Emp
                {
                    EmpID=106,
                    EmpName="Ankita",
                    EmpDesignation="Manager",
                    EmpDOJ=new DateTime(month:08,day:25,year:2010)
                }
            };
            return View(empData);
        }
    }
}
