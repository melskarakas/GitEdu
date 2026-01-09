using ORM.Business;
using ORM.Models.Models;
using ORM.Models.Models.ViewModels;
using ORM.Services.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ORM.Services.Services
{
    public class StudentService : IStudentService
    {
        public bool Add(students entity)
        {
            return new GenericBusiness<students>().Add(entity);
        }

        public bool Delete(object id)
        {
            return new GenericBusiness<students>().Delete(id);
        }

        public List<students> GetAll(bool is_active)
        {
            string w = $" AND {nameof(students.is_active)}={is_active}";
            if (is_active)
            {
                return new GenericBusiness<students>().GetAllByCustomQuery(w).ToList();
            }
            else
            {
                return new GenericBusiness<students>().GetAll().ToList();
            }
        }

        public students GetById(object id)
        {
            return new GenericBusiness<students>().GetById(id);
        }

        public List<vw_student_lesson> GetByLessonId(object lesson_id)
        {

            string w = $" AND {nameof(vw_student_lesson.lesson_id)}='{lesson_id}'";
            return new GenericBusiness<vw_student_lesson>().GetAllByCustomQuery(w).ToList();
        }

        public bool Update(students entity)
        {
            return new GenericBusiness<students>().Update(entity);
        }
    }
}
