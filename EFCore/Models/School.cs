using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework.Models
{
    public class School
    {
        public int Id { get; set; }
        public ICollection<Class> Classes { get; set; }

    }
}
