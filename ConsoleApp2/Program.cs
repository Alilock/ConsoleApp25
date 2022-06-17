using System;

namespace ConsoleApp2
{
    internal class Program
    {


        public static void Main(string[] args)
        {
            Baku baku = new Baku();
            string option;
            do
            {
                
                Console.WriteLine("1. Employee elave et");
                Console.WriteLine("2. Student elave et");
                Console.WriteLine("3. Employeelerin sayini goster");
                Console.WriteLine("4. Studentlerin sayini goster");
                Console.WriteLine("5. Employeelere bax");
                Console.WriteLine("6. Studentlere bax");
                Console.WriteLine("7. Insanlar uzere axtaris et");
                Console.WriteLine("0. Menudan cix");
                 option = Console.ReadLine();
                switch (option)
                {
                    case "1":
                        Console.Write("Iscinin adini yazin: ");
                        string name = Console.ReadLine();
                        Console.Write("Iscinin soyadini yazin: ");
                        string surname = Console.ReadLine();
                        Console.Write("Iscinin vezifesini yazin: ");
                        string position = Console.ReadLine();
                        Employee emp = new Employee(name, surname)
                        {
                            Position = position
                        };
                        baku.AddHuman(emp);



                        break;
                    case "2":
                        Console.Write("Telebenin adini yazin: ");
                        string namee = Console.ReadLine();
                        Console.Write("Telebenin soyadini yazin: ");
                        string surName = Console.ReadLine();

                        Console.Write("Telebenin qiymetini yazin: ");
                        string grade = Console.ReadLine();
                        Console.WriteLine("Telebenin qrup nomresini yazin: ");
                        string groupNo = Console.ReadLine();
                        Student student = new Student(namee, surName)
                        {
                            Grade = grade,
                            GroupNo = groupNo
                        };

                        baku.AddHuman(student);
                        break;
                    case "3":
                        Console.WriteLine("Iscilerin sayi: " + baku.GetEmployees().Length);

                        break;
                    case "4":
                        Console.WriteLine("Telebelerin sayi: " + baku.GetStudents().Length);
                        break;
                    case "5":

                        foreach (var item in baku.GetEmployees())
                        {
                            item.ShowInfo();
                        }
                        break;
                    case "6":
                        foreach (var item in baku.GetStudents())
                        {
                            item.ShowInfo();
                        }
                        break;
                    case "7":
                        Console.WriteLine("Axtaris deyerini daxil edin: ");
                        string search = Console.ReadLine();
                       foreach( var item in baku.SearchHumans(search))
                        {
                            item.ShowInfo();
                        }
                        break;
                    default:
                        Console.WriteLine("Duzgun secim edin");
                        
                        break;
                }

            } while (option!="0");

        }

    }
}
