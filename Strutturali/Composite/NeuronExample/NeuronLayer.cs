using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace DesignPatternDimitri.Strutturali.Composite.NeuronExample
{
    public class NeuronLayer:Collection<Neuron>
    {
        public NeuronLayer(int count)
        {
            while (count-- > 0)
            {
                Add(new Neuron());
            }
        }
    }
}
