using System.Collections.Generic;
using System.Collections.ObjectModel;
using System;

namespace Library
{
    public class PersonVisitor : Visitor<Person>
    {
        private HashSet<Person> visitedPersons = new HashSet<Person>();
        /* A HashSet is a collection class in C# that represents a set of unique values. 
        It is part of the System.Collections.Generic namespace. 
        The main characteristic of a HashSet is that it does not allow duplicate elements, 
        and it ensures that all elements stored within it are distinct. */
        public int AgeSum { get; set; }

        public override void Visit(Node<Person> node)
        {
            
            ///////////////////////
            var person = node.getObj;

            // Check if the person has already been visited
            if (!visitedPersons.Contains(person))
            {
                AgeSum += person.Age;
                Console.WriteLine(node.getObj.Age);
                Console.WriteLine($"Subtotal = {AgeSum}");
                visitedPersons.Add(person);
            }

            ///////////////////////


            /* AgeSum += node.getObj.Age;
            Console.WriteLine(node.getObj.Age);
            Console.WriteLine($"Subtotal = {AgeSum}"); */
            foreach (var child in node.Children)
            {
                child.Accept(this);
                
            }
        }

    }
    
}