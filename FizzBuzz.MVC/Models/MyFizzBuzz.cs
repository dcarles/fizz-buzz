using System;
using System.Collections.Generic;

namespace FizzBuzz.MVC.Models
{
    public class MyFizzBuzz
    {
        private readonly Func<DateTime> _now;


        public MyFizzBuzz(Func<DateTime> now)
        {
            _now = now;
        }

        public List<string> GetFizzBuzz(int value)
        {
            if (value < 1 || value > 1000)
                throw new ArgumentException("Value should be greater than Zero and less than 1001");

            var numbers = new List<string>();

            for (var i = 1; i <= value; i++)
            {
                numbers.Add(GetFizzBuzzValue(i));
            }
            return numbers;
        }

        private string GetFizzBuzzValue(int i)
        {
            if (i % 3 == 0 && i % 5 == 0)
            {
                if (_now().DayOfWeek == DayOfWeek.Wednesday)
                    return "WizzWuzz";
                else
                    return "FizzBuzz";
            }
            else if (i % 3 == 0)
            {
                if (_now().DayOfWeek == DayOfWeek.Wednesday)
                    return "Wizz";
                else
                    return "Fizz";
            }
            else if (i % 5 == 0)
            {
                if (_now().DayOfWeek == DayOfWeek.Wednesday)
                    return "Wuzz";
                else
                    return "Buzz";
            }
            else
            {
                return i.ToString();
            }
        }
    }
}