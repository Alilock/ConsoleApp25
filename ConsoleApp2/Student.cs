using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    internal class Student : Human
    {
        public Student(string name, string surname) : base(name, surname)
        {
        }
        public string Grade;
        public string GroupNo;
        public override void ShowInfo()
        {
            Console.WriteLine(Name + " " + Surname + " " + Age+ "Grade: " + Grade + "GroupNo: " + GroupNo );
        }
    }
}
