using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UdemyDesignPatterns.Prototype.CopyConstructors
{

    public class Employee
    {
        public string Name;
        public Address Address;

        public Employee(string name, Address address)
        {
            Name = name;
            Address = address;
        }

        public Employee(Employee other)
        {
            Name = other.Name;
            Address = new Address(other.Address);
        }

        public override string ToString()
        {
            return $"{nameof(Name)}: {Name}, {nameof(Address)}: {Address}";
        }
    }
}
