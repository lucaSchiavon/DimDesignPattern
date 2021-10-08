using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternDimitri.Strutturali.Proxy
{
    public class Property<T> where T : new()
    {
        private T value;
        private readonly string name;
        public T Value
        {
            get => value;
            set
            {
                if (Equals(this.value, value)) return;
                Console.WriteLine($"assigning {value} to {name}");
            }
        }
        public Property()
            : this(default(T)) 
        {

        }
        public Property(T value, string name="")
        {
            this.value=value;
            this.name = name;
        }

        public static implicit operator T(Property<T> property)
        {
            return property.value;
        }

        public static implicit operator Property<T>(T value)
        {
            return new Property<T>(value);
        }
    }
}
