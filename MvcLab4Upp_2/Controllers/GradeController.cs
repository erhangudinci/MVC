using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcLab4Upp_2.Models;

namespace MvcLab4Upp_2.Controllers
{
    public class GradeController : Controller
    {
        // GET: Grade
        public PartialViewResult ShowGrade()
        {
            List<Grade> grades = ((Student) Session["student"]).Grades;
            return PartialView(grades);
        }

        public PartialViewResult AddGrade()
        {
            return PartialView();
        }
        [HttpPost]
        public ActionResult AddGrade(Grade grade)
        {

            ((Student)Session["student"]).Grades.Add(grade);
            return RedirectToAction("ShowGrade", routeValues: new { id = 2 });
        }
    }
}