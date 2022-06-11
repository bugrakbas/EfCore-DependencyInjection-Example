using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extension
{
    public class Attributes
    {
        [AttributeUsage(AttributeTargets.Class)]
        public class TableAttribute : Attribute
        {
            public string Name { get; set; }
            public TableAttribute(string name)
            {
                Name = name;
            }
        }
        [AttributeUsage(AttributeTargets.Property)]
        public class ColumnAttribute : Attribute
        {
            public string Name { get; }
            public string Type { get; }
            public string Required { get; }
            public ColumnAttribute(string name, string type, string required)
            {
                Name = name;
                Type = type;
                Required = required;
            }
        }
    }
}
