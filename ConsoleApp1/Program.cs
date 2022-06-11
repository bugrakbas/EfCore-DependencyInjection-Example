// See https://aka.ms/new-console-template for more information

using Extension;
using Extension.Extensions;
using Microsoft.Graph;
using System.Reflection;
using System.Text.RegularExpressions;
using static Extension.Attributes;
//# region Extensions
//var a = DateTime.Now;
//a.Ago();
//#endregion


//Attribute kullanımı
#region Attribute
Student student = new Student();
student.Id = 5;
static string Validate(Student student)
{

    Type type = typeof(Student);
    PropertyInfo? pi = type.GetProperty(nameof(Student.Id));
    var classAttribute = type.GetCustomAttribute<TableAttribute>();
    var propertyAttribute = pi?.GetCustomAttribute<ColumnAttribute>();
    if (!Regex.IsMatch(classAttribute.Name, "^[a-zA-Z0-9]*$"))
    {
        return "Tablo adı ingilizce harfler içermelidir";
    }
    string result = "Tablo adı :" + classAttribute.Name + " --- kolonlari " + propertyAttribute.Name + " tipi " + propertyAttribute.Type + " " + propertyAttribute.Required;
    return result;

}
Console.WriteLine(Validate(student));
#endregion


