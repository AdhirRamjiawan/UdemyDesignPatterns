﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UdemyDesignPatterns.SOLID.OpenClosePrinciple
{
    public class AndSpec<T> : ISpecification<T>
    {
        private ISpecification<T> first, second;

        public AndSpec(ISpecification<T> first, ISpecification<T> second)
        {
            if (first == null)
                throw new ArgumentNullException(paramName: nameof(first));

            if (second == null)
                throw new ArgumentNullException(paramName: nameof(second));

            this.first = first; 
            this.second = second;
        }

        public bool IsSatisfied(T t)
        {
            return first.IsSatisfied(t) && second.IsSatisfied(t);
        }
    }
}
