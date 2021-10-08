using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternDimitri.Creazionali.Builder.Inheritance.Soluzione
{
   public class PersonJobBuilder<SELF>
        :PersonInfoBuilder<PersonJobBuilder<SELF>>
        where SELF: PersonJobBuilder<SELF>
    {
        public SELF WorksAsA(string position)
        {
            person.Position = position;
            SELF a = (SELF)this;
            return a;
        }
    }
}
