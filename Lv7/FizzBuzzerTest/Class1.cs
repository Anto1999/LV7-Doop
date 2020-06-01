using FizzBuzz;
using NUnit.Framework;
using System;

namespace FizzBuzzerTest
{
    [TestFixture]
    public class FizzBuzzTests
    {
        //arrange
        FizzBuzzer fizz = new FizzBuzzer();


        [TestCase("dizajn")]
        [TestCase("Palindrom")]
        [TestCase("U")]
        [TestCase("Objektno-orijentiranom")]
        [TestCase(" programiranju.")]
        [TestCase("Anto")]
        public void Convert_Palindrom(string input)
        {
            bool expected = false;
            //act
            bool actual = fizz.Check(input);
            //assrt
            Assert.AreEqual(expected, actual);
        }


    }
}