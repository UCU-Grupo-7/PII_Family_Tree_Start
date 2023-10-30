using System;
using Library;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {/* 
            Node n1 = new Node(1);
            Node n2 = new Node(2);
            Node n3 = new Node(3);
            Node n4 = new Node(4);
            Node n5 = new Node(5);
            Node n6 = new Node(6);
            Node n7 = new Node(7);

            n1.AddChildren(n2);
            n1.AddChildren(n3);

            n2.AddChildren(n4);
            n2.AddChildren(n5);

            n3.AddChildren(n6);
            n3.AddChildren(n7); */

            // visitar el árbol aquí

            Person person1 = new Person("Juan", 60);
            Person person2 = new Person("Jose", 24);
            Person person3 = new Person("Josefina", 18);

            Node<Person> node1 = new Node<Person>(person1);
            Node<Person> node2 = new Node<Person>(person2);
            Node<Person> node3 = new Node<Person>(person3);

            node1.AddChildren(node2);
            node1.AddChildren(node3);
        }
    }
}
