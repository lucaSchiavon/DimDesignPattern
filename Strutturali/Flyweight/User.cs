using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternDimitri.Strutturali.Flyweight
{
    public class User
    {
        public string FullName { get; }

        public User(string fullName)
        {
            FullName = fullName;
        }
    }
}
