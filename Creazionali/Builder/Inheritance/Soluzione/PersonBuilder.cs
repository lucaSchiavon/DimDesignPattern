using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternDimitri.Creazionali.Builder.Inheritance.Soluzione
{
    public class PersonBuilder
    {
        protected Person person = new Person();

        public Person Build()
        {
            return person;
        }
    }
}
