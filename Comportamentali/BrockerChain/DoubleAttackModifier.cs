using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternDimitri.Comportamentali.BrockerChain
{
    //sottoscrittori concreti
    class DoubleAttackModifier : CreatureModifier
    {
        public DoubleAttackModifier(Game game,Creature creature)
            :base(game,creature)
        {

        }

        //viene fatto l'override della callback astratta
        protected override void Handle(object sender, Query q)
        {
            if (q.CreatureName == creature.Name &&
                 q.WhatToQuery == Query.Argument.Attack)
                q.Value *= 2;
        }
    }
}
