using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Extension.Attributes;



namespace Extension
{
    [Table("ogrenci")]
    public class Student
    {
        [Column("id", "int", "zorunlu")]
        public int Id { get; set; }
    }
}
