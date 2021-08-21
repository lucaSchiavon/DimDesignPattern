using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternDimitri.OPC
{
    class SizeSpecification : ISpecification<Product>
    {
        private Size Size;

        public SizeSpecification(Size size)
        {
            Size = size;
        }
        public override bool IsSatisfied(Product p)
        {
            return p.Size == Size;

        }
        //public bool IsSatisfied(Product p)
        //{
        //    return p.Size == Size;
               
        //}
    }
}
