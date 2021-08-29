using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternDimitri.Creazionali.Builder.Inheritance
{
    public class PersonInfoBuilder: PersonBuilder
    {
        public PersonInfoBuilder Called(string name)
        {
            person.Name = name;
            return this;
        }
    }
}
