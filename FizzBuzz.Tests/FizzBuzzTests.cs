using System;
using System.Collections;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using FizzBuzz.MVC.Models;
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

        private readonly DateTime notWednesday = new DateTime(2016, 2, 21);
        private readonly DateTime wednesday = new DateTime(2016, 2, 17);


        [Test]
        public void GetFizzBuzz_Should_Return_List_With_One_If_Input_Is_One()
        {

            // Arrange
            var fizbuzz = new MyFizzBuzz(()=> notWednesday);
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
            var fizbuzz = new MyFizzBuzz(() => notWednesday);
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
            var fizbuzz = new MyFizzBuzz(() => notWednesday);
            var expected = new List<string> { "1", "2", "Fizz" };

            // Act
            var actual = fizbuzz.GetFizzBuzz(3);

            // Assert
            CollectionAssert.AreEqual(expected, actual);

        }

        [Test]
        public void GetFizzBuzz_Should_Return_List_With_One_Two_Wizz_If_Input_Is_Three_And_Is_Wednesday()
        {
            // Arrange
            var fizbuzz = new MyFizzBuzz(() => wednesday);
            var expected = new List<string> { "1", "2", "Wizz" };

            // Act
            var actual = fizbuzz.GetFizzBuzz(3);

            // Assert
            CollectionAssert.AreEqual(expected, actual);

        }

        [Test]
        public void GetFizzBuzz_Should_Return_List_With_One_Two_Fizz_Four_Buzz_If_Input_Is_Five()
        {
            // Arrange
            var fizbuzz = new MyFizzBuzz(() => notWednesday);
            var expected = new List<string> { "1", "2", "Fizz", "4", "Buzz" };

            // Act
            var actual = fizbuzz.GetFizzBuzz(5);

            // Assert
            CollectionAssert.AreEqual(expected, actual);

        }

        [Test]
        public void GetFizzBuzz_Should_Return_List_With_One_Two_Wizz_Four_Wuzz_If_Input_Is_Five_And_Is_Wednesday()
        {
            // Arrange
            var fizbuzz = new MyFizzBuzz(() => wednesday);
            var expected = new List<string> { "1", "2", "Wizz", "4", "Wuzz" };

            // Act
            var actual = fizbuzz.GetFizzBuzz(5);

            // Assert
            CollectionAssert.AreEqual(expected, actual);

        }

        [Test]
        public void GetFizzBuzz_Should_Return_FizzBuzz_For_15th_Position_If_Input_Is_15_Or_Greater()
        {
            // Arrange
            var fizbuzz = new MyFizzBuzz(() => notWednesday);
            var position = 15;
            var expected = "FizzBuzz";

            // Act
            var actualFizzBuzzList = fizbuzz.GetFizzBuzz(position);
            var actual = actualFizzBuzzList.ElementAt(position - 1); // As lists are 0 index based we need to access the 14th item to get the correct position

            // Assert
            Assert.AreEqual(expected, actual);

        }


        [Test]
        public void GetFizzBuzz_Should_Return_WizzWuzz_For_15th_Position_If_Input_Is_15_Or_Greater_And_Is_Wednesday()
        {
            // Arrange
            var fizbuzz = new MyFizzBuzz(() => wednesday);
            var position = 15;
            var expected = "WizzWuzz";

            // Act
            var actualFizzBuzzList = fizbuzz.GetFizzBuzz(position);
            var actual = actualFizzBuzzList.ElementAt(position - 1); // As lists are 0 index based we need to access the 14th item to get the correct position

            // Assert
            Assert.AreEqual(expected, actual);

        }


        [Test]
        public void GetFizzBuzz_Should_Return_Exception_If_Input_Is_Less_Than_One()
        {
            // Arrange
            var fizbuzz = new MyFizzBuzz(() => notWednesday);

            // Act
            // Assert
            Assert.Throws<ArgumentException>(() => fizbuzz.GetFizzBuzz(0));

        }

        [Test]
        public void GetFizzBuzz_Should_Return_Exception_If_Input_Is_Greater_Than_Thousand()
        {
            // Arrange
            var fizbuzz = new MyFizzBuzz(() => notWednesday);

            // Act
            // Assert
            Assert.Throws<ArgumentException>(() => fizbuzz.GetFizzBuzz(1001));

        }



    }

   
}
