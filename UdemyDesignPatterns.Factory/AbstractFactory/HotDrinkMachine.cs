using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UdemyDesignPatterns.Factory.AbstractFactory
{


    public class HotDrinkMachine
    {
        //bad - breaks open/close principle.
        //public enum AvailableDrink
        //{
        //    Coffee,
        //    Tea
        //}


        //private Dictionary<AvailableDrink, IHotDrinkFactory> Factories = new Dictionary<AvailableDrink, IHotDrinkFactory>();

        //public HotDrinkMachine()
        //{
        //    foreach (AvailableDrink drink in Enum.GetValues(typeof(AvailableDrink)))
        //    {
        //        // this doesn't seem right... from the course
        //        var factory = (IHotDrinkFactory)Activator.CreateInstance(Type.GetType("UdemyDesignPatterns.Factory.AbstractFactory" + Enum.GetName(typeof(AvailableDrink), drink)));

        //        Factories.Add(drink, factory);
        //    }
        //}

        //public IHotDrink MakeDrink(AvailableDrink drink, int amount)
        //{
        //    return Factories[drink].Prepare(amount);
        //}

        private List<Tuple<string, IHotDrinkFactory>> Factories = new List<Tuple<string, IHotDrinkFactory>>();

        public HotDrinkMachine()
        {
            foreach (var type in typeof(HotDrinkMachine).Assembly.GetTypes())
            {
                if (typeof(IHotDrinkFactory).IsAssignableFrom(type) && !type.IsInterface)
                {
                    Factories.Add(Tuple.Create<string, IHotDrinkFactory>(type.Name.Replace("Factory", string.Empty),
                        (IHotDrinkFactory)Activator.CreateInstance(type)));
                }
            }
        }

        public IHotDrink MakeDrink(string drink, int amount)
        {
            var factory = Factories.Where(x => x.Item1 == drink).FirstOrDefault();
            if (factory != null)
                return factory.Item2.Prepare(amount);

            return null;
        }
    }
}
