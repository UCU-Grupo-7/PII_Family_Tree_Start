using System.Collections.Generic;
using System.Collections.ObjectModel;
using System;

namespace Library
{
    public class Person 
    {
        private string Name{get; set;}
        private int Age{get; set;}

        public Person(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }

    }
}

