using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternDimitri.OPC
{
    public interface IFilter<T>
    {
        IEnumerable<T> Filter(IEnumerable<T> items, ISpecification<T> spec);
    }
}
