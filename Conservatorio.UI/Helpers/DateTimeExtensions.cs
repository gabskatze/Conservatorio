using System;

namespace Conservatorio.UI.Helpers
{
    public static class DateTimeExtensions
    {
        public static DateTime EnPunto(this DateTime dateTime)
        {
            return dateTime
                .AddMinutes(dateTime.Minute * -1)
                .AddSeconds(dateTime.Second * -1)
                .AddMilliseconds(dateTime.Millisecond * -1);
        }

    }
}
