using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ORM.Models.Models.ViewModels
{
    [Table(nameof(vw_student_lesson))]
    public class vw_student_lesson:BaseModel
    {
        public Guid student_lesson_id { get; set; }
        public Guid lesson_id { get; set; }
        public Guid student_id { get; set; }
        public string lesson_name { get; set; }
        public string lesson_code { get; set; }
        public int lesson_time { get; set; }
        public string name_surname { get; set; }
        public string student_number { get; set; }
        public string email { get; set; }
        public string phone_number { get; set; }
        public DateTime last_login_time { get; set; }
        public bool is_registration { get; set; }
        public Guid created_by { get; set; }
        public Guid modified_by { get; set; }
    }
}
