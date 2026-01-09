using APP.API.Auth;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ORM.Services.IServices;
using ORM.Services.Services;
using System.Threading.Tasks;
using System;
using ORM.Models.Models;

namespace APP.API.Controllers
{
    [AuthorizeAttribute]
    [ApiController]
    [Route("[controller]/[action]")]
    public class StudentsController : ControllerBase
    {
        private readonly IStudentService _studentService;
        public StudentsController(IStudentService studentService)
        {
            _studentService = studentService;
        }

        [HttpGet]
        public ObjectResult GetById(Guid id)
        {
            try
            {
                var user = _studentService.GetById(id);
                return Ok(user);
            }
            catch (Exception ex)
            {
                return Problem(detail: "Genel Hata: " + ex.Message, statusCode: 500);
            }
        }
        [HttpGet]
        public ObjectResult GetByLessonId(Guid lesson_id)
        {
            try
            {
                var result = _studentService.GetByLessonId(lesson_id);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return Problem(detail: "Genel Hata: " + ex.Message, statusCode: 500);
            }
        }
        [HttpGet]
        public ObjectResult GetAll(bool is_active)
        {
            try
            {
                var user = _studentService.GetAll(is_active);
                return Ok(user);
            }
            catch (Exception ex)
            {
                return Problem(detail: "Genel Hata: " + ex.Message, statusCode: 500);
            }
        }

        [HttpPost]
        public ObjectResult Add(students entity)
        {
            try
            {
                bool res = _studentService.Add(entity);
                return Ok(res);
            }
            catch (Exception ex)
            {
                return Problem(detail: "Genel Hata: " + ex.Message, statusCode: 500);
            }
        }
        [HttpPut]
        public ObjectResult Update(students entity)
        {
            try
            {
                bool res = _studentService.Update(entity);
                return Ok(res);
            }
            catch (Exception ex)
            {
                return Problem(detail: "Genel Hata: " + ex.Message, statusCode: 500);
            }
        }
        [HttpDelete]
        public ObjectResult Delete(Guid id)
        {
            try
            {
                bool res = _studentService.Delete(id);
                return Ok(res);
            }
            catch (Exception ex)
            {
                return Problem(detail: "Genel Hata: " + ex.Message, statusCode: 500);
            }
        }
    }
}
