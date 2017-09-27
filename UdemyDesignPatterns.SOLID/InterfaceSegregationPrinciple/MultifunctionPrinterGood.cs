using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UdemyDesignPatterns.SOLID.InterfaceSegregationPrinciple
{
    public class MultifunctionPrinterGood : IMultifunction
    {
        IPrinter Printer;
        IScanner Scanner;
        IFaxer Faxer;

        public MultifunctionPrinterGood(IPrinter printer, IScanner scanner, IFaxer faxer)
        {
            Scanner = scanner;
            Printer = printer;
            Faxer = faxer;
        }

        public void Fax(Document d)
        {
            Faxer.Fax(d);
        }

        public void Print(Document d)
        {
            Printer.Print(d);
        }

        public void Scan(Document d)
        {
            Scanner.Scan(d);
        }
    }
}
