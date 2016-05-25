using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcLab4Upp_2.Models;

namespace MvcLab4Upp_2.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult Details()
        {
            var student = new Student
            {
                StudentId = 1,
                Address = "kaboom",
                LastName = "gudinci",
                Name = "erhan",
                Grades = new List<Grade>
                {
                    new Grade
                    {
                        CourseName = "Svenska",
                        GradeId = 1,
                        GivenGrade = "A"
                    }
                }
            };
            
            Session["student"] = student;
            return View(student);
        }

    }
}