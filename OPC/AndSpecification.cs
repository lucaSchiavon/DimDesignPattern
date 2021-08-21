using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternDimitri.OPC
{
    public class AndSpecification<T> : ISpecification<T>
    {
        private readonly ISpecification<T> first,second;

        public AndSpecification(ISpecification<T> first, ISpecification<T> second)
        {
            this.first = first;
            this.second = second;
        }

        public override bool IsSatisfied(T item)
        {
            return first.IsSatisfied(item) && second.IsSatisfied(item);
        }

        //public  bool IsSatisfied(T item)
        //{
        //    return first.IsSatisfied(item) && second.IsSatisfied(item);
        //}
    }
}
