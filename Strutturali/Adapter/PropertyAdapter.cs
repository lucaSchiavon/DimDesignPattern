using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace DesignPatternDimitri.Strutturali.Adapter
{
    //andiamo a costruire una proprietà che esponga il dictionary in modo che sia semplice da serializzare
    //(il dictionary non è serializzabiole di default...)
    class PropertyAdapter
    {
        [XmlIgnore]
        public Dictionary<string, string> Capitals { get; set; }

        public (string, string)[] CapitalsSerializable
        {
            get 
            {
                //dal dictionary alla restituzione dell'array di tuple
                return Capitals.Keys.Select(country => (country, Capitals[country])).ToArray();
            }
            set 
            {
                //riceve un array di tuple e le mette in un dictionary
                Capitals = value.ToDictionary(x => x.Item1, x => x.Item2);
            }
        }
    }
}
