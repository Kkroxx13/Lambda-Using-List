using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace LambdaExpressionUsingList
{
    public class Operations

    {
        List<Person> listPersonsInCity = new List<Person>() { new Person("000000", "Karan", "Nashik", 22), 
                                                              new Person("111111", "Sagar", "Mumbai", 23),
                                                              new Person("222222", "Bhavesh", "Ambarnath", 24),
                                                              new Person("333333", "Archit", "Pune", 19),
                                                              new Person("444444", "Mihir", "Nerul", 23) 
                                                             };
             
        public bool Findall()
        {        

            foreach (Person person in listPersonsInCity.FindAll(e => (e.Age >= 20)).Take(2).ToList())
            {
                Console.WriteLine("Person : " + person.Name + " age: " + person.Age);
            }
            return true;

        }
        public bool TeenagerorNot()
        {
            
            if (listPersonsInCity.Any(e => (e.Age >= 13 && e.Age <= 19)))   //ANY method here return bool value
            {
                Console.WriteLine("Yes, we have some teenager");
            }
            else
            {
                Console.WriteLine("Exception");
            }
            foreach (Person person in listPersonsInCity.FindAll(e => (e.Age >= 13 && e.Age <= 19)))
            {
                Console.WriteLine("Person : " + person.Name + " age: " + person.Age);
            }
            return true;

        }
        public double GetAverage()
        {
            double avgAge = listPersonsInCity.Average(e => e.Age);
            Console.WriteLine("The Average of all persons age is :" + avgAge);
            return avgAge;
        }
        public bool GetName()
        {
            if (listPersonsInCity.Exists(e => e.Name == "Karan"))
            {
                Console.WriteLine("Yes, a person having name 'Karan' exists in our list");
            }
            
            foreach (Person person in listPersonsInCity.FindAll(e => e.Name == "Karan"))
            {
                Console.WriteLine("Person : " + person.Name + " age: " + person.Age);
            }
            return true;
        }
    }
}
