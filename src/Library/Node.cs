using System.Collections.Generic;
using System.Collections.ObjectModel;
using System;
using System.Runtime.InteropServices;

namespace Library
{
    public class Node
    {
        private int number;

        public Person person;

        public Person Person_Creator(string name, int age)
        {
            Person person = new Person(name, age);
            return person;
         }    //es el creator de persons en node.
         

        private List<Node> children = new List<Node>();

        public int Number {
            get
            {
                return this.number;
            }
        }

        public ReadOnlyCollection<Node> Children {
            get
            {
                return this.children.AsReadOnly();
            }
        }

        public Node(string name, int age)
        {
            this.person = Person_Creator(name,age);
        }

        public void AddChildren(Node n)
        {
            this.children.Add(n);
        }
    }
}
