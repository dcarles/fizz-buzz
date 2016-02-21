using System;
using System.Collections.Generic;

namespace FizzBuzz.MVC.Models
{
    public class MyFizzBuzz
    {
        public List<string> GetFizzBuzz(int value)
        {
            if(value < 1 ||value > 1000)
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
                return "FizzBuzz";
            }
            else if (i % 3 == 0)
            {
                return "Fizz";
            }
            else if (i % 5 == 0)
            {
                return "Buzz";
            }
            else
            {
                return i.ToString();
            }
        }
    }
}