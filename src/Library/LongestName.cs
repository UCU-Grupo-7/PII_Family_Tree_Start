using System.Collections.Generic;
using System.Collections.ObjectModel;
using System;

namespace Library
{
    public class LongestName : Visitor<Person>
    {
        public Person Longest {get; private set;}
        public LongestName(){
            Longest = null;
        }
        
        public override void Visit(Node<Person> node)
        {
            if (node.getObj != null)
            {
                if (Longest == null || node.getObj.Name.Length > Longest.Name.Length)
                {
                    Longest = node.getObj;
                }
            }
            foreach (var child in node.Children)
            {
                child.Accept(this);
            }
        }
    }
}


