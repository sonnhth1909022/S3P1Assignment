using S3P1Assignment.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace S3P1Assignment.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult GetStudentData()
        {
            List<Student> student = new List<Student>
            {
                new Student
                {
                    name = "Sơn",
                    age = 26,
                    address = "Thinh Quang, Dong Da"
                },
                new Student
                {
                    name = "Peter Parker",
                    age = 26,
                    address = "New York City"
                }
            };

            TempData["student"] = student;
            TempData.Keep();
            return View();
        }
    }
}