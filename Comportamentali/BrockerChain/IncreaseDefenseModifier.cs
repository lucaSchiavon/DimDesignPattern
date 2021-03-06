using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternDimitri.Comportamentali.BrockerChain
{
    //sottoscrittori concreti
    class IncreaseDefenseModifier : CreatureModifier
    {
        public IncreaseDefenseModifier(Game game,Creature creature)
            :base(game,creature)
        {

        }

        protected override void Handle(object sender, Query q)
        {
            if (q.CreatureName == creature.Name &&
                 q.WhatToQuery == Query.Argument.Defense)
                q.Value *= 2;
        }
    }
}
