using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternDimitri.Strutturali.Proxy
{
    public class Creature
    {
       public readonly Property<int> agility = new Strutturali.Proxy.Property<int>(10, nameof(Agility));

        public int Agility
        {
            get => agility.Value;
            set => agility.Value = value;
        }
    }
}
