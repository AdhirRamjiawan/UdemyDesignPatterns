using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UdemyDesignPatterns.Builder
{
    public class Usage
    {
        public static void Run()
        {
            var hello = "hello";
            var sb = new StringBuilder();

            sb.Append("<p>");
            sb.Append(hello);
            sb.Append("</p>");

            Console.WriteLine(sb.ToString());

            // below code is too much effort to repeat
            var words = new[] { "hello", "world" };

            sb.Clear();
            sb.Append("<ul>");

            foreach (var word in words)
            {
                sb.Append("<li>");
                sb.Append(word);
                sb.Append("</li>");
            }
            
            sb.Append("</ul>");

            Console.WriteLine(sb.ToString());


            // Builder Pattern way
            var builder = new HtmlBuilder("ul");
            builder.AddChild("li", "hello");
            builder.AddChild("li", "world");
            Console.WriteLine(builder.ToString());
        }
    }
}
