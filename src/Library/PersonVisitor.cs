using System.Collections.Generic;
using System.Collections.ObjectModel;
using System;

namespace Library
{
    public class PersonVisitor : Visitor<Person>
    {
        private HashSet<Person> visitedPersons = new HashSet<Person>(); 
        //Esto soluciona un problema que teniamos que a la hora de recorrer los nodos 
        //ya que recorria varias veces los hijos y sumaba sus edades cada vez dando un resultado incorrecto

        /* A HashSet is a collection class in C# that represents a set of unique values. 
        It is part of the System.Collections.Generic namespace. 
        The main characteristic of a HashSet is that it does not allow duplicate elements, 
        and it ensures that all elements stored within it are distinct. */
        public int AgeSum { get; set; }

        public override void Visit(Node<Person> node)
        {
            
            ///////////////////////
            var person = node.getObj;

            // Verifica si la persona ya fue visitada
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
                Console.WriteLine(child.getObj.Age);

                child.Accept(this);
            }
        }

    }
    
}