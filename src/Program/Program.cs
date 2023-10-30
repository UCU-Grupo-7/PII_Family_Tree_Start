using System;
using Library;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Node n1 = new Node(1);
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
            n3.AddChildren(n7);*/

            // visitar el árbol aquí

            Node person1 = new Node("Juan",24);
            Node person2 = new Node ("Jose", 54);
            Node person3 = new Node("Julia", 56);
            Node person4 = new Node("Josefina",16);

            person2.AddChildren(person4);
            person2.AddChildren(person1);

            Console.WriteLine(person1.Children);


        }
    }
}
