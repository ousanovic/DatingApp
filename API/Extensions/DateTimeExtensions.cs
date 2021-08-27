using System;

namespace API.Extensions
{
    public static class DateTimeExtensions
    {
        public static int CalculateAge(this DateTime dob){
            var today = DateTime.Today;
            return (int) Math.Truncate(today.Subtract(dob).TotalDays/365.25);
        }
    }
}