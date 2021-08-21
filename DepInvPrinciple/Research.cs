using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternDimitri.DepInvPrinciple
{
    public class Research
    {
        //this class doesn't know nothing about how research method was implemented....
        public Research(IRelationshipBrowser browser)
        {
            foreach (var p in browser.FindAllChildrenOf("John"))
            {
                Console.WriteLine($"John has a child called {p.Name}");
            }
        }
    }
}
