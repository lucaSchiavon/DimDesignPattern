using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternDimitri.Strutturali.Composite.NeuronExample
{
    //diamo ad un oggetto o ad un gruppo di oggetti una identica interfaccia
    //in modo che lavorino correttamente con lo stesso metodo/metodi (connectTo)
    public class Neuron: IEnumerable<Neuron>
    {
        public List<Neuron> In, Out;

        public Neuron()
        {
            In = new List<Neuron>();
            Out = new List<Neuron>();
        }
        //public void ConnectTo(Neuron other)
        //{
        //    Out.Add(this);
        //    other.In.Add(this);

        //}
     
        //siccome la versione IEnumerable generica deriva dalla non generica
        //occorre implementare sia la versione generica che non generica di IEnumerable

        public IEnumerator<Neuron> GetEnumerator()
        {
            //qui viene implementata l'enumerazione
            yield return this;
        }

        //la versione non generica invoca la generica...
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
