using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternDimitri.Comportamentali.Chain
{
    public class IncreaseDefenseModifier: CreatureModifier
    {
        public IncreaseDefenseModifier(Creature creature)
            :base(creature)
        { 
        
        }

        public override void Handle()
        {
            if (creature.Attack <= 2)
            {
                Console.WriteLine($"Increasing {creature.Name}'s defense");
                creature.Defense++;
            }
            base.Handle();
        }
    }
}
