using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternDimitri.Comportamentali.BrockerChain
{
    //event broker
    public class Game
    {
        public event EventHandler<Query> Queries;
       //invoca
        public void PerformQuery(Object sender, Query q)
        {
            Queries?.Invoke(sender, q);
        }
    }
}
