using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework.Models
{
    public class Teacher
    {
        public int Id { get; set; }
        public Lesson Lesson { get; set; }
    }
}
