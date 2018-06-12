using System;
using System.Collections.Generic;
using System.Globalization;

namespace LastSundays
{
    public class LastSunday
    {
        public List<string> GetLastSunday(int year)
        {
            List<string> listOfMonths = new List<string>();
            int daysInMonths = DateTime.DaysInMonth(year, 1);
            for(int day =daysInMonths; day > 0; day++)
            {
                daysInMonths -= 1;
            }

            for (int month = 1; month <= 12; month++)
            {
                var currentDate = new DateTime(year, month, 1).AddMonths(1).AddDays(-1);

                while (currentDate.DayOfWeek != DayOfWeek.Sunday)
                {
                    currentDate = currentDate.AddDays(-1);
                }
                listOfMonths.Add(currentDate.ToString("yyyy-MM-dd"));
            }
            return listOfMonths;
        }
    }
}