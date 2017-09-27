using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UdemyDesignPatterns.SOLID.DependencyInversionPrinciple
{
    public class Usage
    {
        public Usage(Relationships relationships)
        {
            var _relationships = relationships.Relations.ToList();
            // bad as you're accessing a low level member (datasource) of the Relationships class
        }

        public void Run()
        {
            var parent = new Person();
            var child1 = new Person();
            var child2 = new Person();

            var relationships = new Relationships();

            relationships.AddParentAndChild(parent, child1);
            relationships.AddParentAndChild(parent, child2);
        }
    }
}
