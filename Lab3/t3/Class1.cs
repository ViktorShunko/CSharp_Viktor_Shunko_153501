using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace t3
{
    public class DateService
    {
        static int[] number_of_days_in_month = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
        static public int week_number(int month, int day)
        {
            int d = 0;
            for (int m = 0; m < month - 1; m++)
            {
                d += number_of_days_in_month[m];
            }
            d += day;
            return (d / 7 + 1);
        }
        static public int duration(int year1, int month1, int day1, int year2, int month2, int day2)
        {
            int d1 = convert_to_days(year1,month1,day1);
            int d2 = convert_to_days(year2, month2, day2);
            if (d1 > d2)
            {
                return d1 - d2;
            }
            else
            {
                return d2 - d1;
            }
        }
        static public int convert_to_days(int year, int month, int day)
        {
            int dm = 0;
            for (int m = 0; m < month - 1; ++m)
                dm += number_of_days_in_month[m];
            return (365 * (year - 1) + (year - 1) / 4 + dm + day);
        }

    }
}
