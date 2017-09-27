﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UdemyDesignPatterns.SOLID.InterfaceSegregationPrinciple
{
    public interface IMultifunction : IPrinter, IScanner, IFaxer
    {
    }
}
