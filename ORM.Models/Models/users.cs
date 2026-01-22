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
    [Table(nameof(users))]
    public class users : BaseModel
    {
        [ExplicitKey]
        public Guid id { get; set; }
        public Guid student_id { get; set; }
        public Guid teacher_id { get; set; }
        public string user_name { get; set; }
        public string password { get; set; }
        public int user_type { get; set; }
        public string name_surname { get; set; }
        public string email { get; set; }
        public string phone_number { get; set; }
        public DateTime last_login_time { get; set; }
        public bool is_verify { get; set; }

    }
}
