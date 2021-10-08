using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternDimitri.Comportamentali.BrockerChain
{
    //questo è il sottoscrittore astratto
    public abstract class CreatureModifier : IDisposable
    {
        protected Game game;
        protected Creature creature;
       

        protected CreatureModifier(Game game, Creature creature)
        {
            this.game = game;
            this.creature = creature;
            //sottoscrive definendo la callback da chiamare
            //qui registra tutte le callback da chiamare di tutti i modifier concreti ossia sottoscrittori
            game.Queries += Handle; //subscribe
        }

        //la callback è astratta e viene definita nelle classi concrete
        protected abstract void Handle(object sender, Query q);

        public void Dispose()
        {
            game.Queries -= Handle; //unsubscribe
        }
    }
}
