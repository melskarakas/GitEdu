using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ORM.Models.Models
{
    [Table(nameof(teachers))]
    public class teachers:BaseModel
    {
        [ExplicitKey]
        public Guid id { get; set; }
        public string name_surname { get; set; }
        public string email { get; set; }
        public string phone_number { get; set; }
        public string teacher_code { get; set; }
        public string filed_of_study { get; set; }
    }
}
