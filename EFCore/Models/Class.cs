using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework.Models
{
    public class Class
    {
        public int Id { get; set; }
        public ICollection<Student> Students { get; set; }
        public  ICollection<Lesson> Lessons { get; set; }
    }
}
