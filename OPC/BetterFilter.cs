using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternDimitri.OPC
{
    public class BetterFilter : IFilter<Product>
    {
        //questa classe rimane generica e disaccoppiata dalla modalità di filtro!!!
        public IEnumerable<Product> Filter(IEnumerable<Product> items, ISpecification<Product> spec)
        {
            foreach (var i in items)
            {
                if (spec.IsSatisfied(i))
                {
                    yield return i;
                }
            }
        }
    }
}
