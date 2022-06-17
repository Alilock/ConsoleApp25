using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    internal class Human
    {
        public Human(string name, string surname)
        {
            Name = name;
            Surname = surname;
        }
        private string _name;
        private string _surname;
        public string Name
        {
            get { return _name; }
            set
            {
                if (CheckName(value))
                {
                    _name = value;
                }
            }
        }
        public string Surname
        {
            get { return _surname; }
            set
            {
                if (CheckName(value))
                {
                    _surname = value;
                }
            }
        }
        public byte Age;
        public virtual void ShowInfo()
        {
            Console.WriteLine(Name + " " + Surname + " " + Age);
        }

        public static bool CheckName(string name)
        {
            if (string.IsNullOrEmpty(name))
            {
                for (int i = 0; i < name.Length; i++)
                {
                    if (!Char.IsLetter(name[i]))
                    {
                        return false;
                    }
                }
                return true;
            }
            return false;

        }
    }

}
