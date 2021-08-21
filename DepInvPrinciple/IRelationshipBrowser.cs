using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternDimitri.DepInvPrinciple
{
    public interface IRelationshipBrowser
    {
        IEnumerable<Person> FindAllChildrenOf(string name);
    }
}
