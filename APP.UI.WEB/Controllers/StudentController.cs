using APP.UI.WEB.BaseClasses;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ORM.Models.Models;
using ORM.Models.Models.ViewModels;
using System;
using System.Collections.Generic;

namespace APP.UI.WEB.Controllers
{
    public class StudentController : Controller
    {
        CurrentSession CurrentSession;
        private readonly ISession _session;
        public StudentController(IHttpContextAccessor session)
        {
            _session = session.HttpContext.Session;
            CurrentSession = new CurrentSession(_session);
        }
        public IActionResult Index()
        {
            List<students> studentList = Operations.GET<List<students>>($"Students/GetAllId?is_actve=true");
            return View(studentList);
        }
        public ActionResult GetStudent(Guid student_id)
        {
            students student = Operations.GET<students>($"Students/GetById?id={student_id}");
            return View(student);
        }
        public ActionResult GetByLessonId(Guid lesson_id)
        {
            List<vw_student_lesson> studentLessonList = Operations.GET<List<vw_student_lesson>>($"Students/GetByLessonId?lesson_id={lesson_id}");
            return View(studentLessonList);
        }
    }
}
