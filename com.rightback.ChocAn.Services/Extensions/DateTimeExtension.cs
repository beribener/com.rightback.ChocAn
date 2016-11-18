﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.rightback.ChocAn.Services.Extensions
{
    public static class DateTimeExtensions
    {
        public static DateTime Next(this DateTime from, DayOfWeek dayOfWeek)
        {
            DateTime newDate = from;
            while (from.DayOfWeek != dayOfWeek)
            {
                newDate = newDate.AddDays(1);

            }
            return newDate;
        }
        public static DateTime Previous(this DateTime from, DayOfWeek dayOfWeek)
        {
            DateTime newDate = from;
            while (newDate.DayOfWeek != dayOfWeek)
            {
                newDate = newDate.AddDays(-1);
            }
            return newDate;
        }
    }
}
