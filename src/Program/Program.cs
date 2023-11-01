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

            /* 
            // Parte 1
            Person person1 = new Person("Juan", 60);
            Person person2 = new Person("Jose", 24);
            Person person3 = new Person("Josefina", 18);

            Node<Person> node1 = new Node<Person>(person1);
            Node<Person> node2 = new Node<Person>(person2);
            Node<Person> node3 = new Node<Person>(person3);

            node1.AddChildren(node2);
            node1.AddChildren(node3); 
            */

            //Parte 2

            Person abueloPadre = new Person("Julio", 85);
            Person abuelaPadre = new Person("Margarita", 75);
            Person abueloMadre = new Person("Ramon", 80);
            Person abuelaMadre = new Person("Marta", 72);
            Person padre = new Person("Roberto", 58);
            Person madre = new Person("Maria", 49);
            Person hijo1 = new Person("Belen", 16);
            Person hijo2 = new Person("Matias", 22);
            Person hijo3 = new Person("Luis", 28);

            Node<Person> nodeAbueloP = new Node<Person>(abueloPadre);
            Node<Person> nodeAbuelaP = new Node<Person>(abuelaPadre);

            Node<Person> nodeAbueloM = new Node<Person>(abueloMadre);
            Node<Person> nodeAbuelaM = new Node<Person>(abuelaMadre);

            Node<Person> nodePadre = new Node<Person>(padre);
            Node<Person> nodeMadre = new Node<Person>(madre);

            Node<Person> nodeHijo1 = new Node<Person>(hijo1);
            Node<Person> nodeHijo2 = new Node<Person>(hijo2);
            Node<Person> nodeHijo3 = new Node<Person>(hijo3);

            nodeAbueloP.AddChildren(nodePadre);
            nodeAbuelaP.AddChildren(nodePadre);

            nodeAbueloM.AddChildren(nodeMadre);
            nodeAbuelaM.AddChildren(nodeMadre);

            nodePadre.AddChildren(nodeHijo1);
            nodePadre.AddChildren(nodeHijo2);
            nodePadre.AddChildren(nodeHijo3);

            nodeMadre.AddChildren(nodeHijo1);
            nodeMadre.AddChildren(nodeHijo2);
            nodeMadre.AddChildren(nodeHijo3);

            //Parte 3

            PersonVisitor personVisitor = new PersonVisitor();
            nodeAbueloP.Accept(personVisitor);
            Console.WriteLine($"Total age sum = {personVisitor.AgeSum}");
            


        }
    }
}
