using APP.UI.WEB.BaseClasses;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ORM.Models.Models;
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
        public ActionResult SaveStudent(students student)
        {
            try
            {
                string _message = "";
                if (student.id != Guid.Empty)
                {
                    var result = Operations.POST($"Students/Add", student);
                }
                else
                {
                    var result = Operations.PUT($"Students/Update", student);
                }
                return Json(new { success = false, messge = _message });

            }
            catch (Exception ex)
            {

                return Json(new { success = false, messge = $"Öğrenci eklenirken bir hata oluştu.Hata: {ex.Message}" });
            }
        }
        public ActionResult DeleteStudent(Guid student_id)
        {
            try
            {
              students student=Operations.GET<students>($"Students/GetById?id={student_id}");
                student.is_active = false;
                student.is_deleted = true;
                student.modified_by = CurrentSession.userAuthInfo.id;
                student.modified_date = DateTime.Now;
                return Json(new { success = false, messge = "Öğrenci silinmiştir." });
            }
            catch (Exception ex)
            {

                return Json(new { success = false, messge = $"Öğrenci eklenirken bir hata oluştu.Hata: {ex.Message}" });
            }
        }
    }
}
