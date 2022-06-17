using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    internal class Baku : City
    {
        Human[] Humans = new Human[0];
        public Human[] humans { get=> Humans; }
        

        public void AddHuman(Human human)
        {
            Array.Resize(ref Humans, Humans.Length + 1);
            Humans[Humans.Length-1] = human;
        }

        public Human[] SearchHumans(string search)
        {
            Human[] searchHumans = new Human[0];
            for (int i = 0; i < Humans.Length; i++)
            {
                string fullname = Humans[i].Name + Humans[i].Surname;
                if (fullname.Contains(search))
                {
                    Array.Resize(ref searchHumans, searchHumans.Length + 1);
                    searchHumans[searchHumans.Length - 1] = Humans[i];
                }
            }

            return searchHumans;
        }
        public Human[] GetStudents()
        {
            Human[] students = new Human[0];
            foreach (var item in Humans)
            {
                if (item is Student)
                {
                    Array.Resize(ref students, students.Length + 1);
                    students[students.Length - 1] = item;
                }
            }
            return students;
        }
        public Human[] GetEmployees()
        {
            Human[] employees = new Human[0];
            foreach (var item in Humans)
            {
                if (item is Employee)
                {
                    Array.Resize(ref employees, employees.Length + 1);
                    employees[employees.Length - 1] = item;
                }
            }
            return employees;
        }
    }
}
