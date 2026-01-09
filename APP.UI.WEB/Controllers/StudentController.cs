using APP.UI.WEB.BaseClasses;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ORM.Models.Models;
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
    }
}
