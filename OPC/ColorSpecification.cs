using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternDimitri.OPC
{
    class ColorSpecification : ISpecification<Product>
    {
        private Color Color;

        public ColorSpecification(Color color)
        {
            Color = color;
        }

        public override bool IsSatisfied(Product p)
        {
            return p.Color == Color;

        }

        //public  bool IsSatisfied(Product p)
        //{
        //    return p.Color == Color;

        //}
    }
}
