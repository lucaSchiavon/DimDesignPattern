using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternDimitri.Creazionali.Builder.Inheritance.Soluzione
{
    public class PersonInfoBuilder<SELF>:PersonBuilder
        where SELF : PersonInfoBuilder<SELF>
    {
        public SELF Called(string name)
        {
            person.Name = name;
            return (SELF)this;
        }
    }
}
