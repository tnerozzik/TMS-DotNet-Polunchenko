using System;
using System.Collections.Generic;

namespace TMS.Polunchenko.Homework6
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var type = 0;
            Run run = new Run();

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
                            var runing = Methods.AdditionRun(weight);
                            running = runing;
                        }
                        break;

                    case 2:
                        {
                            var yoga = Methods.AdditionYoga(weight);
                            uogi = yoga;
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
            }
        }

        
    }
}