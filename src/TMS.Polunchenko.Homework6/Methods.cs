using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMS.Polunchenko.Homework6
{
   public class Methods
    {
        public static List<Run> AdditionRun(int _weight)
        {
            string Stopword;
            bool isStop = false;
            List<Run> eunlist = new List<Run>();
            do
            {
                Console.WriteLine(" enter pulse");

                Console.WriteLine(" enter distance(km)");

                eunlist.Add(new Run
                {
                    Weight = _weight,
                    Pulse = Convert.ToInt32(Console.ReadLine()),

                    Distance = Convert.ToInt32(Console.ReadLine())
                });
                Console.WriteLine("Add more distance?\n1-Add.\n2-No,enough.");
                var input = Console.ReadLine();
                if (input == "1") { Stopword = "false"; }
                else { Stopword = "true"; }

                bool.TryParse(Stopword, out isStop);
            } while (!isStop);

            return eunlist;
        }
        public static List<Yoga> AdditionYoga(int _weight)
        {
            string Stopword;
            bool isStop = false;
            List<Yoga> yogalist = new List<Yoga>();
            do
            {
                Console.WriteLine(" enter pulse");

                Console.WriteLine("and enter duration of training(minutes)");

                yogalist.Add(new Yoga
                {
                    Weight = _weight,
                    Pulse = Convert.ToInt32(Console.ReadLine()),
                    Time = Convert.ToInt32(Console.ReadLine())
                });
                Console.WriteLine("Add more duration?\n1-Add.\n2-No,enough.");
                var input = Console.ReadLine();
                if (input == "1") { Stopword = "false"; }
                else { Stopword = "true"; }

                bool.TryParse(Stopword, out isStop);
            } while (!isStop);

            return yogalist;
        }

        public static void Show(List<Run> _run)
        {
            foreach (var elem in _run)
            {
                elem.GetCalories();
                Console.WriteLine("Running:");
                Console.WriteLine($"Distance:{elem.Distance}km, Calories Burned:{elem.Calories}");
            }
        }

        public static void Show2(List<Yoga> _yoga)
        {
            foreach (var elem in _yoga)
            {
                elem.GetCalories();
                Console.WriteLine("Yoga:");
                Console.WriteLine($"Duration:{elem.Time},Calories Burned:{elem.Calories}");
            }
        }
         public static void OverCalories(List<Run> r, List<Yoga> y)
        {
            var sumruncalories = r.Sum(r => r.Calories);
            int R = Convert.ToInt32(sumruncalories);

            var sumyogacalories = y.Sum(y => y.Calories);
            int Y = Convert.ToInt32(sumyogacalories);

            Console.WriteLine($"Сегодня потрачено калорий: {R + Y}");
        }
    }
}
