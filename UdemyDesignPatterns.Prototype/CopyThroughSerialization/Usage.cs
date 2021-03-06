﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UdemyDesignPatterns.Prototype.CopyThroughSerialization
{
    public class Usage
    {
        public static void Run()
        {
            var john = new Employee("John", new Address("123 London Road", "London", "UK"));

            //var chris = john;
            var chris = john.DeepCopy();

            chris.Name = "Chris";
            Console.WriteLine(john); // oops, john is called chris
            Console.WriteLine(chris);
        }
    }
}
