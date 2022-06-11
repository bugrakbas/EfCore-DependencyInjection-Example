using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extension.Extensions
{
    public static class Extensions
    {
        public static void Ago(this DateTime date)
        {
            DateTime date2 = new DateTime(2009, 8, 3, 12, 8, 0);
            int result = DateTime.Compare(date, date2);
            string relationship;
            var days = date.Day - date2.Day;
            var hours = date.Hour - date2.Hour;
            var minutes = date.Minute - date2.Minute;
            Console.WriteLine("{0} {1} den {2} gün {3} saat {4} dakika önce", date, date2, days, hours, minutes);

        }
    }
}
