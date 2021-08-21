using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternDimitri.Strutturali.Composite.NeuronExample
{
    public abstract class Scalar<T> : IEnumerable<T>
        where T : Scalar<T>
    {
        public IEnumerator<T> GetEnumerator()
        {
           yield return (T)this;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
