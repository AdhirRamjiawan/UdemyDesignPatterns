using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UdemyDesignPatterns.SOLID.DependencyInversionPrinciple
{
    public interface IRelationships // this creates a higher level module and becomes the dependency, not the actual Relationship implementation class.
    {
        List<Tuple<Person, Relationship, Person>> FindAllChildrenOf(string name);
    }

    public class Relationships /* low level module  */ : IRelationships
    {
        private List<Tuple<Person, Relationship, Person>> relations = 
            new List<Tuple<Person, Relationship, Person>>();

        public List<Tuple<Person, Relationship, Person>> Relations => relations;

        public void AddParentAndChild(Person parent, Person child)
        {
            relations.Add(new Tuple<Person, Relationship, Person>(parent, Relationship.Parent, child));
            relations.Add(new Tuple<Person, Relationship, Person>(child, Relationship.Child, parent));
        }

        public List<Tuple<Person, Relationship, Person>> FindAllChildrenOf(string name)
        {
            return new List<Tuple<Person, Relationship, Person>>();
        }
    }
}
