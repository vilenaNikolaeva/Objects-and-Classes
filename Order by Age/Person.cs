using System;
using System.Collections.Generic;
using System.Text;

namespace Order_by_Age
{
    class Person
    {
        public string Name { get; set; }
        public string Id { get; set; }
        public int Age { get; set; }

        public Person(string name, string id, int age)
        {
            this.Name = name;
            this.Id = id;
            this.Age = age;
        }
        public override string ToString()
        {
            return $"{this.Name} with ID:{this.Id} is {this.Age} years old.";
        }


    }
}
