using System;
using System.Collections.Generic;

namespace TMS.Polunchenko.Homework4
{
    class Program
    {
        static void Cl(IClinning clinning)
        {
            clinning.Cliner();
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello in zoo manager");
            Console.WriteLine();




            var type = 0;
            bool CorrectUserInput = false;
            bool isStop = false;
            do
            {   link:
                Console.WriteLine("====================Меню?=====================");
                Console.WriteLine(" \n1-Покормить животных. \n2-Открыть вольеры на прогулку. \n3-записать новое животное. \n4-уборка клеток/вольеров.");
                var action = Console.ReadLine();
                var correctcheck = int.TryParse(action, out type);
                if (correctcheck)
                {
                    switch (type)
                    {
                        case 1:
                            {
                                var openzoo = new Openzoo();
                               openzoo.Food();

                                Console.WriteLine("????????????? \n1-в меню. \n2-выход.");
                                var input = Console.ReadLine();
                                if (input == "1") { goto link; }
                                else { }

                                CorrectUserInput = true;
                            }
                            break;
                        case 2:
                            {
                                var openzoo = new Openzoo();
                                openzoo.Walk();

                                Console.WriteLine("? \n1-в меню. \n2-выход.");
                                var input = Console.ReadLine();
                                if (input == "1") { goto link; }
                                else { }

                                CorrectUserInput = true;
                            }
                            break;
                        case 4:
                            {
                               
                                var clmammals = new Mammals();

                                Cl(clmammals);

                                var clbirds = new Birds();

                                Cl(clbirds);
                                Console.WriteLine();
                            }
                            break;
                        case 3:
                            {
                                
                             do
                             {
                                   
                                       
                                Console.WriteLine(" \n1-Новая птица. \n2 новое млекопитающее");
                                string newani = (Console.ReadLine());
                                int newan = Convert.ToInt32(newani);
                                switch (newan)
                                {
                                    case 1:
                                        {
                                            
                                            var birdss = new List<BirdsSp>();
                                            
                                                Console.WriteLine("Введите информацию о птице");
                                                Console.WriteLine("Цвет:");
                                                var color = Console.ReadLine();
                                                Console.WriteLine("Вид птицы:");
                                                var species = Console.ReadLine();
                                                
                                                Console.WriteLine("Пол(W/M): ");
                                                var sex = Convert.ToChar(Console.ReadLine());
                                                Console.WriteLine("Возраст: ");
                                                var age = Convert.ToInt32(Console.ReadLine());
                                                Console.WriteLine("Место рождения: ");
                                                var place = Console.ReadLine();
                                                Console.WriteLine("Номер клетки: ");
                                                var aviary = Convert.ToInt32(Console.ReadLine());


                                                birdss.Add(new BirdsSp
                                                {
                                                    Color = color,
                                                    Species = species,
                                                });
                                           
                                                var birds = new Birds

                                                 {   
                                                Sex = sex,
                                                Age = age,
                                                PlaceofBirth = place,
                                                AviaryNumber = aviary,
                                                Birdss = new List<BirdsSp>()

                                                 };                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                         
                                                Console.WriteLine();
                                                Console.WriteLine("Новая птица добавлена в базу зоопарка");
                                                Console.WriteLine();
                                                string Stopword;
                                                Console.WriteLine("еще животное? \n1-еще. \n2-конец записи.");
                                                var input = Console.ReadLine();
                                                if (input == "1") { Stopword = "false"; }
                                                else { Stopword = "true"; }

                                                bool.TryParse(Stopword, out isStop);
   
                                            }
                                        break;
                                    case 2:

                                        {
                                            
                                            var mammalss = new List<MammalsSp>();
                                            
                                                Console.WriteLine("Введите информацию о животном");
                                                Console.WriteLine("Цвет:");
                                                var color = Console.ReadLine();
                                                Console.WriteLine("Семейство животного:");
                                                var species = Console.ReadLine();

                                                Console.WriteLine("Пол(W/M): ");
                                                var sex = Convert.ToChar(Console.ReadLine());
                                                Console.WriteLine("Возраст: ");
                                                var age = Convert.ToInt32(Console.ReadLine());
                                                Console.WriteLine("Место рождения: ");
                                                var place = Console.ReadLine();
                                                Console.WriteLine("Номер клетки: ");
                                                var aviary = Convert.ToInt32(Console.ReadLine());


                                                mammalss.Add(new MammalsSp
                                                {
                                                    Color = color,
                                                    Species = species,
                                                });

                                                var mammals = new Mammals

                                                {
                                                    Sex = sex,
                                                    Age = age,
                                                    PlaceofBirth = place,
                                                    AviaryNumber = aviary,
                                                    Mammalss = new List<MammalsSp>()

                                                };
                                                Console.WriteLine();
                                                Console.WriteLine("Новое животное добавлено в базу зоопарка");
                                                Console.WriteLine();
                                                string Stopword;
                                                Console.WriteLine("еще животное? \n1-еще. \n2-конец записи.");
                                                var input = Console.ReadLine();
                                                if (input == "1") { Stopword = "false"; }
                                                else { Stopword = "true"; }

                                                bool.TryParse(Stopword, out isStop);
                                               
                                            
                                            
                                        }
                                        break;

                                }
                              } while (!isStop);
                                CorrectUserInput = true;

                            } break;
                           
                    }
                }
                else
                {
                    Console.WriteLine("No!please enter 1,2,3 or 4!");
                }
             } 
            while (!CorrectUserInput);




        }
    }
}
