using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace SaabeEnergy_backend.Models.Utility
{
    public static class Extensions
    {
        public static string ToPersian(this DateTime datetime)
        {
            PersianCalendar persianCalendar = new PersianCalendar();
            return persianCalendar.GetYear(datetime).ToString() + "/" +
                persianCalendar.GetMonth(datetime).ToString("0#") + "/" +
                persianCalendar.GetDayOfMonth(datetime).ToString("0#") + " " +
                datetime.Hour.ToString("0#") + ":" + datetime.Minute.ToString("0#") + ":" + datetime.Second.ToString("0#");
        }

        public static string ToShortPersian(this DateTime datetime)
        {
            try
            {
                PersianCalendar persianCalendar = new PersianCalendar();
                return persianCalendar.GetYear(datetime).ToString() + "/" +
                    persianCalendar.GetMonth(datetime).ToString("0#") + "/" +
                    persianCalendar.GetDayOfMonth(datetime).ToString("0#");
            }
            catch
            {
                return string.Empty;
            }
        }
    }
}
