using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternDimitri.Comportamentali.BrockerChain
{
    public class Query
    {
        public string CreatureName;
        public Argument WhatToQuery;
        public int Value;
        public enum Argument
        {
            Attack, Defense
        }

        public Query(string creatureName, Argument whatToQuery, int value)
        {
            CreatureName = creatureName;
            WhatToQuery = whatToQuery;
            Value = value;
        }
        //public Query(string creatureName, Argument whatToQuery, int value)
        //{
        //    CreatureName = creatureName;
        //    WhatToQuery = whatToQuery;
        //    Value = value;
        //}
    }
}
