using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace DesignPatternDimitri.Strutturali.Composite.NeuronExample
{
    public abstract class ScalarVer2<T> : Collection<T>
      where T : ScalarVer2<T>
    {
        //public IEnumerator<T> GetEnumerator()
        //{
        //    yield return (T)this;
        //}

        //IEnumerator IEnumerable.GetEnumerator()
        //{
        //    return GetEnumerator();
        //}
    }
}
