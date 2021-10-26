using System;
using System.Collections.Generic;
using System.Linq;

namespace TMS.Polunchenko.Homework6
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var type = 0;
            Run run = new Run();
            run.Notify += Info;

            var running = new List<Run>();
            var uogi = new List<Yoga>();
        

            Console.WriteLine("Hello in fitness treaker, you can count the calories burned");
            Console.WriteLine("Enter your weight(kg):");
            int weight = Convert.ToInt32(Console.ReadLine());
        link:
            Console.WriteLine("Select the type of activity:\n1-running.\n2-yoga.");
            var chose = Console.ReadLine();
            var correctcheck = int.TryParse(chose, out type);
            if (correctcheck)
            {
                switch (type)
                {
                    case 1:
                        {
                             running = Methods.AdditionRun(weight);
                          
                        }
                        break;

                    case 2:
                        {
                            uogi = Methods.AdditionYoga(weight);
                           
                        }
                        break;
                }
            }
            else
            {
                Console.WriteLine("No!please enter 1 or 2,we can only count yoga and running!");
            }

            Console.WriteLine("add more activity?\n (enter yes or no)");
            var input2 = Console.ReadLine();
            if (input2 == "yes")
            {
                goto link;
            }
            else
            {
                Console.WriteLine("Calculation of energy consumption per day......");
                Console.WriteLine($"===========Today{DateTime.Now.ToString("yyyy'-'MM'-'dd")}===========");

                Methods.Show(running);

                Methods.Show2(uogi);
                Methods.OverCalories(running,uogi);
            }
           
        }


        private static void Info(string str)
        {
            Console.WriteLine("повышенная нагрузка");
        }

      
        

    }
}