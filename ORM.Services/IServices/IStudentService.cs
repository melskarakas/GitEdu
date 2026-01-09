using ORM.Models.Models;
using ORM.Models.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ORM.Services.IServices
{
    public interface IStudentService
    {
        bool Add(students entity);
        students GetById(object id);
        List<vw_student_lesson> GetByLessonId(object lesson_id);
        List<students> GetAll(bool is_active);
        bool Update(students entity);
        bool Delete(object id);
    }
}
