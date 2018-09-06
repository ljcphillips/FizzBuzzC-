using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            var divisors = new Dictionary<int, string> { { 3, "Fizz" }, { 5, "Buzz" }, { 7, "Bang" } };
            for (int i = 1; i < 106; i++)
            {
                string returnValue = "";
                foreach (KeyValuePair<int, string> x in divisors)
                {
                    if (i % x.Key == 0)
                    {
                        returnValue += x.Value;
                    }
                }
                Console.WriteLine(returnValue);
                if (returnValue == "")
                {
                    Console.WriteLine(i);
                }
            }
            Console.ReadLine();
        }
    }
}
