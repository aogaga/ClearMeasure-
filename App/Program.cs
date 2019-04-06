using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Fizzbuzz;

namespace App
{
    public class Program
    {
        static void Main(string[] args)
        {

            var list = new List<FizBuzInputValues>
            {
                new FizBuzInputValues() { Value = 3, Word = "Fizz" },
                new FizBuzInputValues() { Value = 5, Word = "Buzz" }
            };

            var fizapp = new FizApp();
            List<string> result = fizapp.GetFizzBuzz(100, list);
   

            foreach (var x in result)
            {
                Console.WriteLine(x);
            }

            Console.ReadLine();
        }
    }
}
