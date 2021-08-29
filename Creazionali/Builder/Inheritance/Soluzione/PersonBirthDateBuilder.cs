using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternDimitri.Creazionali.Builder.Inheritance.Soluzione
{
    //self è il Builder
    public class PersonBirthDateBuilder<SELF>
        :PersonJobBuilder<PersonBirthDateBuilder<SELF>>
        where SELF : PersonBirthDateBuilder<SELF>
    {
        public SELF Born(DateTime dateOfBirth)
        {
            person.DateOfBirth = dateOfBirth;
            return (SELF)this;
        }
    }
}
