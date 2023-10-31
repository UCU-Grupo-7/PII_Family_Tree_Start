using System.Collections.Generic;
using System.Collections.ObjectModel;
using System;

namespace Library
{
    public class Node<T>
    {
        //private int number;
        private T obj;

        public T getObj
        {
            get
            {
                return obj;
            }
        } 

        private List<Node<T>> children = new List<Node<T>>();

       /*  public int Number {
            get
            {
                return this.number;
            }
        } */

        public ReadOnlyCollection<Node<T>> Children {
            get
            {
                return this.children.AsReadOnly();
            }
        }

        public Node(T t)
        {
            this.obj = t;
        }

        public void AddChildren(Node<T> n)
        {
            this.children.Add(n);
        }

        public void Accept(Visitor<T> visitor){
            visitor.Visit(this);

            foreach (var child in children)
            {
                child.Accept(visitor);
                
            }

        }
    }
}
