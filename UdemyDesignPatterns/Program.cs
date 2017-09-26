using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UdemyDesignPatterns.SOLID;

namespace UdemyDesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            JournalBad demoJ = new JournalBad();

            demoJ.AddEntry("new course, yay!");
            demoJ.AddEntry("gonna be cool!");
        }
    }
}
