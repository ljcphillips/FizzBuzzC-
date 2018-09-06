using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    class Program
    {
        static void Main()
        {
            var allMethods = new Dictionary<int, string> { { 3, "Fizz" }, {13, "Fezz" }, { 5, "Buzz" }, { 7, "Bang" }, { 11, "Bong" } };
            for (int i = 1; i < 301; i++)
            {
                var returnValue = new List<string> { };
                foreach (KeyValuePair<int, string> x in allMethods)
                {
                    if (i % x.Key == 0)
                    {
                        returnValue.Add(x.Value);
                    }
                }
                if (returnValue.Any() == false)
                {
                    Console.WriteLine(i);
                }
                else if (returnValue.Contains("Bong"))
                    Bong(returnValue);
                if (i % 17 == 0) {
                    returnValue.Reverse();
                    Console.WriteLine(String.Join("", returnValue));
                }
                else
                Console.WriteLine(String.Join("", returnValue));
            }
            Console.ReadLine();
        }
       
        static void Bong(List<string> returnValue)
        {
            if (returnValue.Contains("Fezz"))
            {
                returnValue.Clear();
                returnValue.Add("FezzBong");
            }
            else
            {
                returnValue.Clear();
                returnValue.Add("Bong");
        }
        }
    }
}



