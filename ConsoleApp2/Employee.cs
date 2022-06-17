using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    internal class Employee : Human
    {
        public Employee(string name, string surname) : base(name, surname)
        {
        }
        public string Position;
        public override void ShowInfo()
        {
            Console.WriteLine(Name + " " + Surname + " " + Age+ "Position: " + Position);
        }
    }
}
