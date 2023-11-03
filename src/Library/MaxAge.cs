using System.Collections.Generic;
using System.Collections.ObjectModel;
using System;

namespace Library
{
    public class MaxAge : Visitor<Person>
    {
        public Person Oldest {get; private set;}
        public MaxAge(){
            Oldest = null;
        }
        
        public override void Visit(Node<Person> node)
        {
            if (node.getObj != null)
            {
                if (Oldest == null || node.getObj.Age > Oldest.Age)
                {
                    Oldest = node.getObj;
                }
            }
            foreach (var child in node.Children)
            {
                child.Accept(this);
            }
        }
    }
}


