using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UdemyDesignPatterns.Builder.Faceted
{
    public class Usage
    {

        public static void Run()
        {
            var personBuilder = new PersonBuilder();
            Person person = 
                personBuilder
                    .Works
                        .At("Lab")
                        .AsA("Software Developer")
                        .Earning(99999999)
                    .Lives
                        .At("Cape Town");


            Console.WriteLine(person);
                
        }
    }
}
