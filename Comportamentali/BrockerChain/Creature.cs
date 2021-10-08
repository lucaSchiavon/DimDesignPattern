using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternDimitri.Comportamentali.BrockerChain
{
    public class Creature
    {
        //game è il mediatore (broker) tra publisher e subscriber
        private Game game;
        public string Name;
        private int attack, defense;
        public Creature(Game game, string name, int attack, int defense)
        {
            this.game = game;
            Name = name;
            this.attack = attack;
            this.defense = defense;
        }
        public void Print()
        {
            //Console.WriteLine($"Name: {Name}, Attack:{Attack}, Defense:{Defense}");
            Console.WriteLine($"Name: {Name}, Attack:{_attack}, Defense:{_defense}");
            
        }
        //public int Attack
        //{
        //    get
        //    {
        //        var q = new Query(Name, Query.Argument.Attack, attack);
        //        //viene pubblicata l'azione
        //        game.PerformQuery(this, q);
        //        return q.Value;
        //    }
        //}
        private int _attack;
        public void Attack()
        {
            var q = new Query(Name, Query.Argument.Attack, attack);
            //viene pubblicata l'azione (rise event)
            game.PerformQuery(this, q);
            _attack = q.Value;
        }
        private int _defense;
        public void Defense()
        {
            var q = new Query(Name, Query.Argument.Defense, defense);
            game.PerformQuery(this, q);
            _defense= q.Value;
        }

        // private int _Attack;
        //public int Attack
        //{
        //    set
        //    {
        //        var q = new Query(Name, Query.Argument.Attack, attack);
        //        //viene pubblicata l'azione
        //        game.PerformQuery(this, q);
        //        _Attack= q.Value;
        //    }
        //    get
        //    {

        //        return _Attack;
        //    }
        //}
        //public int Defense
        //{
        //    get
        //    {
        //        var q = new Query(Name, Query.Argument.Defense, defense);
        //        game.PerformQuery(this, q);
        //        return q.Value;
        //    }
        //}
    }
}
