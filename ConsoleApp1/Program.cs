using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Human[] humans = new Human[0];
            Console.WriteLine("1. Human add ele");
            Console.WriteLine("2. Humanlari goster");
            string opt = Console.ReadLine();
            do
            {
                if (opt == "1")
                {
                    Console.WriteLine("Teacher yoxsa Doctor elave etmek isteyirsiz? T/D");
                    string opt1 = Console.ReadLine();
                    do
                    {
                        if (opt1 == "T")
                        {
                            Console.WriteLine("Teacherin adini yazin: ");
                            string name = Console.ReadLine();
                            Console.WriteLine("Teacherin soyadini yazin: ");
                            string surname = Console.ReadLine();

                            Array.Resize(ref humans, humans.Length + 1);
                            humans[humans.Length - 1] = new Teacher()
                            {
                                Name = name,
                                SurName = surname
                            };
                            break;
                        }
                        else if (opt1 == "D")
                        {
                            Console.WriteLine("Doctorun adini yazin: ");
                            string name = Console.ReadLine();
                            Console.WriteLine("Doctorun soyadini yazin: ");
                            string surname = Console.ReadLine();

                            Array.Resize(ref humans, humans.Length + 1);
                            humans[humans.Length - 1] = new Doctor()
                            {
                                Name = name,
                                SurName = surname
                            };
                            break;
                        }
                    } while (opt == "T" || opt == "D");
                }



                else if (opt == "2")
                {
                    string opt2;
                    do
                    {
                        Console.WriteLine("Teacherleri yoxsa doctorlari gormek isteyirsiz?");
                         opt2 = Console.ReadLine();
                        if (opt2 == "T")
                        {
                            for (int i = 0; i < humans.Length; i++)
                            {
                                if (humans[i] is Teacher)
                                {
                                    Console.WriteLine(humans[i].Name + " " + humans[i].SurName);
                                }
                            }
                        }
                        else if (opt2 == "D")
                        {
                            for (int i = 0; i < humans.Length; i++)
                            {
                                if (humans[i] is Doctor)
                                {
                                    Console.WriteLine(humans[i].Name + " " + humans[i].SurName);
                                }
                            }
                        }
                    } while (opt2!="T" || opt2!="D");
                    
                    
                }

            } while (opt != "1" || opt != "2");


        }

    }
}
