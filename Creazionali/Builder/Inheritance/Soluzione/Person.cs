using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternDimitri.Creazionali.Builder.Inheritance.Soluzione
{
    public class Person
    {
        public string Name;
        public string Position;
        public DateTime DateOfBirth;

        public class Builder : PersonBirthDateBuilder<Builder>
        {
            //costruttore
            internal Builder() { }
        }

        public static Builder New => new Builder();
    }


}
