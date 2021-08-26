using System;
using System.Collections.Generic;
using System.Linq;

namespace LambdaExpressionUsingList
{
    public class Program
    {
       public  static void Main(string[] args)
        {
            Operations operations = new Operations();

            Console.WriteLine("-------------------");
            Console.WriteLine("Retreieving the persons from list having age greater than 20\n");            
            operations.Findall();

            Console.WriteLine("-------------------");
            operations.TeenagerorNot();


            Console.WriteLine("-------------------");
            Console.WriteLine("Getting Average of all persons age");
            operations.GetAverage();


            Console.WriteLine("-------------------");
            Console.WriteLine("Checking whether a person having name 'Karan' exists or not");
            operations.GetName();
           
        }
    }
}
