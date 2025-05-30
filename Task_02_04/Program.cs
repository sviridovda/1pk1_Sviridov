﻿using System.Security.Cryptography.X509Certificates;

namespace Task_02_04;

public static class DateTimeExtensions
{
    static void Main(string[] args);
    public static string ToAgeString(this DateTime dob)
    {
        DateTime today = DateTime.Today;

        int months = today.Month - dob.Month;
        int years = today.Year - dob.Year;

        if (today.Day < dob.Day)
        {
            months--;
        }

        if (months < 0)
        {
            years--;
            months += 12;
        }

        int days = (today - dob.AddMonths((years * 12) + months)).Days;

        return string.Format("{0} year{1}, {2} month{3} and {4} day{5}",
                             years, (years == 1) ? "" : "s",
                             months, (months == 1) ? "" : "s",
                             days, (days == 1) ? "" : "s");
    }
}
