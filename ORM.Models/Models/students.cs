using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using ORM.Shared;

namespace ORM.Models.Models
{
    [Table(nameof(students))]
    public class students:BaseModel
    {
        [ExplicitKey]
        public Guid id { get; set; }
        public string name_surname { get; set; }
        public string student_number { get; set; }
        public string email { get; set; }
        public string phone_number { get; set; }
        public DateTime last_login_time { get; set; }
        public bool is_verify { get; set; }

    }
}
