using System.Collections.Generic;
using System.Collections.ObjectModel;
using System;

namespace Library
{
    public class PersonVisitor : Visitor<Person>
    {
        public int AgeSum { get; set; }

        public override void Visit(Node<Person> node)
        {
            AgeSum += node.getObj.Age;
            Console.WriteLine(node.getObj.Age);
            Console.WriteLine(AgeSum);
            foreach (var child in node.Children)
            {
                child.Accept(this);
                
            }
        }

    }
    
}