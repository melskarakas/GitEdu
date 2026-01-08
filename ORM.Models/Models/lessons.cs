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
    [Table(nameof(lessons))]
    public class lessons:BaseModel
    {
        [ExplicitKey]
        public Guid id { get; set; }
        public string lesson_code { get; set; }
    }
}
