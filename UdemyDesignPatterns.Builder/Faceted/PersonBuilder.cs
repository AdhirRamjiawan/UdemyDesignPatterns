using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UdemyDesignPatterns.Builder.Faceted
{
    public class PersonBuilder //facade
    {
        protected Person person = new Person();

        public PersonJobBuilder Works => new PersonJobBuilder(person); // API
        public PersonAddressBuilder Lives => new PersonAddressBuilder(person); // Another Faceted API

        public static implicit operator Person(PersonBuilder pb)
        {
            return pb.person;
        }
    }
}
