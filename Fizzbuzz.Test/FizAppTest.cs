using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Fizzbuzz.Test
{

    [TestFixture]
    public class FizAppTest
    {
        public FizApp fizApp;
        public List<FizBuzInputValues> appValues;

        [SetUp]
        public void Init()
        {
           fizApp = new FizApp();
           appValues = new List<FizBuzInputValues>();

        }


        [Test]
        public void GetFixBuzzReturnsBuzzWithMultiplesOfThree()
        {

            appValues.Add(new FizBuzInputValues() { Value = 3, Word = "Fizz" });

            var result = fizApp.GetFizzBuzz(5, appValues).ToArray();

            Assert.AreEqual("Fizz", result[2].Trim());

        }

        [Test]
        public void GetFixBuzzReturnsBuzzWithMultiplesOfFive()
        {
          
            appValues.Add(new FizBuzInputValues() { Value = 5, Word = "Buzz" });

            var result = fizApp.GetFizzBuzz(5, appValues).ToArray();

           Assert.AreEqual("Buzz", result[4].Trim());

        }



    }
}
