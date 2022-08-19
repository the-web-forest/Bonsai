using System;
namespace Bonsai.Helpers
{
	public static class DateHelper
	{
        public static DateTime BrazilDateTimeNow() => TimeZoneInfo.ConvertTime(DateTime.Now, TimeZoneInfo.FindSystemTimeZoneById("E. South America Standard Time"));
    }
}

