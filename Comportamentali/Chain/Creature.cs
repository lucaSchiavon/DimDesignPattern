using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternDimitri.Comportamentali.Chain
{
    public class Creature
    {
        public string Name;
        public int Attack, Defense;
     
        public Creature(string name, int attack, int defense)
        {
            Name = name;
            Attack = attack;
            Defense = defense;
        }
    }
}
