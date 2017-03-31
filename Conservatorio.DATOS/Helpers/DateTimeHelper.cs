using System;

namespace Conservatorio.DATOS.Helpers
{
    public static class DateTimeHelper
    {
        public static DateTime EnPunto(this DateTime dateTime)
        {
            return dateTime
                .AddMinutes(dateTime.Minute * -1)
                .AddSeconds(dateTime.Second * -1)
                .AddMilliseconds(dateTime.Millisecond * -1);
        }

        public static DateTime FromString(string hora, string format)
        {
            return DateTime.Now;
        }
    }
}
