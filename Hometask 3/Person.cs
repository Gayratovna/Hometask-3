using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hometask_3
{
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Person(string name, int age)
        {
            this.Name = name;
            this.Age = age;
            
        }

        public void Check(int age)
        {
            if (Age > age) 
            {
                Console.WriteLine($"Age: {Age}");
            }
        }

        public void Check(string name, int age)
        {
            if(Age < age)
            {
                Console.WriteLine($"Name: {name}\n" +
                                  $"Age: {age}");
            }
        }
    }
}
