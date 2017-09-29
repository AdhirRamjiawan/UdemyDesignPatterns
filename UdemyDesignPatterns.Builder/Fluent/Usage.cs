using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UdemyDesignPatterns.Builder.Fluent
{
    public class Usage
    {
        public static void Run()
        {
            // Fluent Builder Pattern way
            var builder = new HtmlBuilder("ul");

            // addChild method can be chained so it's "Fluent".
            builder.AddChild("li", "hello")
                    .AddChild("li", "world");

            Console.WriteLine(builder.ToString());
        }
    }
}
