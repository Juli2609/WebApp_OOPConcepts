using System;
using System.Collections.Generic;
using System.Text;

namespace WebApp_OOPConcepts
{
    public class Date
    {
        #region Fields
        
        private int _year;
        private int _month;
        private int _day;

        #endregion

        #region Methods
        public Date(int year, int month, int day)
        {
            _year = CheckYear(year);
            _month = CheckMonth(month);
            _day = CheckDay(day, month, year);
            
        }

        private int CheckYear(int year)
        {
            if (year >= 1900)
            {
                return year;
            }

            throw new YearException("The year is invalid!");
        }

        private int CheckDay(int day, int month, int year)
        {
            if (month == 2 && day == 29 && IsLeapYear(year))
            {
                return day;
            }
            int[] daysPorMonth = { 0, 31, 28, 31, 30, 31, 30, 31, 31, 30, 30, 31 }; // every array starts at 0

            if(day >= 1 && day <= daysPorMonth[month])
            {
                return day;
            }
            throw new DayException("That day is invalid!");
        }

        private bool IsLeapYear(int year) 
        {
            return year % 400 == 0 || year % 4 == 0 && year % 100 != 0;
        }

        private int CheckMonth(int month)
        {

            if (month >= 1 && month <= 12)
            {
                return month;
            }
            throw new MonthException("The month is invalid!");
        }

        public override string ToString()
        {
             return String.Format("{0:0000}/{1:00}/{2:00}", _year, _month, _day);
            //other options, all funtionals  -> $"{_year}/{_month}/{_day}";    (_year + "/" + _month + "/" + _day);

        }
        #endregion


    }
}
