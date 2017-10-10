using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UdemyDesignPatterns.Factory.AbstractFactory
{
    public class Usage
    {
        public static void Run()
        {
            var machine = new HotDrinkMachine();
            var drink = machine.MakeDrink(HotDrinkMachine.AvailableDrink.Tea, 10);
            drink.Consume();
        }
    }
}
