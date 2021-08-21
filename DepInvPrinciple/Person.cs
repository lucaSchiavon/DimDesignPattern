using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternDimitri.DepInvPrinciple
{
    public enum Relationship
    { 
        Parent,
        Child,
        Sibling
    }
    public class Person
    {
        public string Name;

        public Person(string name)
        {
            Name = name;
        }
    }
}
