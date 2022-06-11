using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework.Models
{
    public class Lesson
    {
        public int LessonId { get; set; }
        public int TeacherId { get; set; }
        public Teacher Teacher { get; set; }
    }
}
