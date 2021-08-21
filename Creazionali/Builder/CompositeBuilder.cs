using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternDimitri.Creazionali.Builder
{
    public class Person
    {
        public string StreetAddress,Postcode,City;
        public string CompanyName, Position;
        public int AnnualIncome;
    }

    public class PersonBuilder
    {
        protected Person person;
        public PersonBuilder()
        {
            this.person = new Person();
        }
        protected PersonBuilder(Person person)
        {
            this.person = person;
        }

        public  PersonAddressBuilder Lives
        {
            get {
                return new PersonAddressBuilder(person);
            }
            
        }

        //public PersonJobBuilder Work()
        //{
        //    return new PersonJobBuilder(person);
        //}

        public static implicit operator Person(PersonBuilder pb)
        {
            return pb.person;
        }
    }



    public class PersonAddressBuilder : PersonBuilder
    {
        public PersonAddressBuilder(Person person)
            :base(person)
        {
            this.person = person;
        }

        public PersonAddressBuilder At(string streetAddress)
        {
            this.person.StreetAddress = streetAddress;
            return this;
        }
        public PersonAddressBuilder WithPostcode(string postcode)
        {
            this.person.Postcode = postcode;
            return this;
        }
        public PersonAddressBuilder In(string city)
        {
            this.person.City = city;
            return this;
        }
    }



}
