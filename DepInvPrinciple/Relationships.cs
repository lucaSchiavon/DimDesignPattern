using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatternDimitri.DepInvPrinciple
{
    public class Relationships:IRelationshipBrowser
    {
        //we can write many class like this and inject when using research class if we want many
        //different method of research
        private List<(Person, Relationship, Person)> relations = new List<(Person, Relationship, Person)>();

        public void AddParentAndChild(Person parent, Person child)
        {
            relations.Add((parent, Relationship.Parent, child));
            relations.Add((child, Relationship.Child, parent));
        }
        //this is concrete implementation of searching
        public IEnumerable<Person> FindAllChildrenOf(string name)
        {
            return relations
                .Where(x => x.Item1.Name == name && x.Item2 == Relationship.Parent)
                .Select(r => r.Item3);
        }
        //public IEnumerable<Person> FindAllChildrenOf(string name)
        //{ }
    }
}
