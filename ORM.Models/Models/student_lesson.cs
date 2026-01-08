using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ORM.Models.Models
{
    [Table(nameof(student_lesson))]
    public class student_lesson:BaseModel
    {
        [ExplicitKey]
        public Guid id { get; set; }
        public Guid student_id { get; set; }
        public Guid lesson_id { get; set; }
    }
}
