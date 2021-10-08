using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternDimitri.Comportamentali.Chain
{
    public class CreatureModifier
    {
        protected Creature creature;
        protected CreatureModifier next;

        public CreatureModifier(Creature creature)
        {
            this.creature = creature;
        }

        public void Add(CreatureModifier cm)
        {
            if (next != null) next.Add(cm);
            else next = cm;
        }

        public virtual void Handle()
        {
            //handle the next item if exist
            next?.Handle();
        }

    }
}
