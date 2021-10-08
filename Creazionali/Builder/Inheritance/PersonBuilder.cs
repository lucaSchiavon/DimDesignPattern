using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternDimitri.Creazionali.Builder.Inheritance
{
    public class PersonBuilder
    {
        protected Person person = new Person();

       //delle proprietà qui...

        public Person Build()
        {
            return person;
        }
    }
}
