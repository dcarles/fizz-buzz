using System.Collections.Generic;

namespace FizzBuzz.MVC.Models
{
    public class MyFizzBuzz
    {
        public List<string> GetFizzBuzz(int value)
        {
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