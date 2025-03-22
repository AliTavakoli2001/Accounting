using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Accounting.Utility.Convert
{
    public static class DateConvert
    {
        public static string toShamsi(this DateTime date)
        {
            PersianCalendar PC = new PersianCalendar();
            return PC.GetYear(date) + "/" + PC.GetMonth(date).ToString("00") + "/" + PC.GetDayOfMonth(date).ToString("00");
        }

        public static DateTime toMilady(this DateTime value)
        {
            Calendar Persian = new PersianCalendar();
            DateTime date = new DateTime(value.Year, value.Month, value.Day, Persian);
            return date;
        }
    }
}
