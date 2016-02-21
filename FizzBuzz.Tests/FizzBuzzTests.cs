using System;
using System.Collections;
using System.Text;
using System.Collections.Generic;
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

    }

    public class MyFizzBuzz
    {
        public IEnumerable GetFizzBuzz(int value)
        {
            var numbers = new List<string>();

            for (var i = 1; i <= value; i++)
            {
                if (i % 3 == 0)
                {
                    numbers.Add("Fizz");
                }
                else
                {
                    numbers.Add(i.ToString());
                }
            }
            return numbers;
        }
    }
}
