using System;
using System.Collections;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;

namespace FizzBuzz.Tests
{
    /// <summary>
    /// Summary description for FizzBuzzTests
    /// </summary>
    [TestFixture]
    public class FizzBuzzTests
    {
        public FizzBuzzTests()
        {
            //
            // TODO: Add constructor logic here
            //
        }

        [Test]
        public void GetFizzBuzz_Should_Return_List_With_One_If_Input_Is_One()
        {

            // Arrange
            var fizbuzz = new MyFizzBuzz();
            var expected = new List<string> { "1" };

            // Act
            var actual = fizbuzz.GetFizzBuzz(1);

            // Assert
            CollectionAssert.AreEqual(expected, actual);

        }

        [Test]
        public void GetFizzBuzz_Should_Return_List_With_One_Two_If_Input_Is_Two()
        {

            // Arrange
            var fizbuzz = new MyFizzBuzz();
            var expected = new List<string> { "1", "2" };

            // Act
            var actual = fizbuzz.GetFizzBuzz(2);

            // Assert
            CollectionAssert.AreEqual(expected, actual);

        }

        [Test]
        public void GetFizzBuzz_Should_Return_List_With_One_Two_Fizz_If_Input_Is_Three()
        {
            // Arrange
            var fizbuzz = new MyFizzBuzz();
            var expected = new List<string> { "1", "2", "Fizz" };

            // Act
            var actual = fizbuzz.GetFizzBuzz(3);

            // Assert
            CollectionAssert.AreEqual(expected, actual);

        }

        [Test]
        public void GetFizzBuzz_Should_Return_List_With_One_Two_Fizz_Four_Buzz_If_Input_Is_Five()
        {
            // Arrange
            var fizbuzz = new MyFizzBuzz();
            var expected = new List<string> { "1", "2", "Fizz", "4", "Buzz" };

            // Act
            var actual = fizbuzz.GetFizzBuzz(5);

            // Assert
            CollectionAssert.AreEqual(expected, actual);

        }

        [Test]
        public void GetFizzBuzz_Should_Return_FizzBuzz_For_15th_Position_If_Input_Is_15_Or_Greater()
        {
            // Arrange
            var fizbuzz = new MyFizzBuzz();
            var position = 15;
            var expected = "FizzBuzz";

            // Act
            var actualFizzBuzzList = fizbuzz.GetFizzBuzz(position);
            var actual = actualFizzBuzzList.ElementAt(position - 1); // As lists are 0 index based we need to access the 14th item to get the correct position

            // Assert
            Assert.AreEqual(expected, actual);

        }

    }

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
            if (i%3 == 0 && i%5 == 0)
            {
               return "FizzBuzz";
            }
            else if (i%3 == 0)
            {
               return "Fizz";
            }
            else if (i%5 == 0)
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
