using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatternDimitri.Strutturali.Flyweight
{
    public class User2
    {
        private static List<string> strings = new List<string>();
        private int[] names;
        public User2(string fullName)
        {
            //in base a fullname seleziona nell'array contenute in fullname per ciascuna parola
            //se contenuta, se non è contenuta viene aggiunta e il suo indice memorizzato
            //nell'array names di int, se è già contenuta viene recuperato
            //il suo indice e messo nell'array di interi names
            names = fullName.Split(' ').Select(getOrAdd).ToArray();
        }
        public string FullName
        {
            get { return string.Join(" ", names.Select(i => strings[i]));  }
        }
        private int getOrAdd(string s)
        {
            int idx = strings.IndexOf(s);
            if (idx != -1) return idx;
            else
            {
                strings.Add(s);
                return strings.Count - 1;
            }
        }
    }
}
