using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ORM.Models.Models
{
    [Table(nameof(teacher_lesson))]
    public class teacher_lesson : BaseModel
    {
        [ExplicitKey]
        public Guid id { get; set; }
        public Guid teacher_id { get; set; }
        public Guid lesson_id { get; set; }
    }
}
