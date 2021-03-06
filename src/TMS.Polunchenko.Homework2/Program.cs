using System;
using System.Text.RegularExpressions;

namespace TMS.Polunchenko.Homework2
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Description();

            string User_y_m = Inputcase1_y_m();
            string Userday = Inputcase2_d();

            DateTime datetime = DateTime.Parse(User_y_m);
            DateTime datetimenext = datetime.AddMonths(1);

            while (datetime != datetimenext)
            {
                string forcompare = datetime.ToString("dddd");

                if (Userday == forcompare)
                {
                    Console.WriteLine(datetime.ToString("MM/dd/yyyy"));
                    Console.ReadKey();

                    //break; // добавил выход из цикла
                }
                
                datetime = datetime.AddDays(1); // проблема была в данной строке
            }
        }

        private static void Description()
        {
            Console.WriteLine("Программа для вывода дат требуемого дня недели оперделенного месяца и года");
        }

        private static string Inputcase1_y_m()
        {
            string regex = @"\d{2}-[0-1]{1}[0-9]{1}-\d{4}";
            Console.WriteLine("Введите месяц");
            string month = Console.ReadLine();
            Console.WriteLine("Введите год");
            string year = Console.ReadLine();
            //var userInput = Console.ReadLine();
            string daybegginofmonth = "01";
            string Datein = daybegginofmonth + "-" + month + "-" + year;

            if (Regex.IsMatch(Datein, regex, RegexOptions.IgnoreCase))
            {
                return Datein;
            }
            else
            {
                Console.WriteLine("Некорректная дата");
                return "0";//????
            }
        }

        private static string Inputcase2_d()
        {   //add:regex for input
            Console.WriteLine("Введите день недели на русском языке ");
            string dayofweek = Console.ReadLine();
            return dayofweek;
        }
    }
}
