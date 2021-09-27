using System;
using System.Text.RegularExpressions;
namespace TMS.Polunchenko.Homework1._1
{
    class Program
    {
        static void Main(string[] args)
        {
            string reg = @"\d{2}-[0-1]{1}[0-9]{1}-\d{4}";
            Console.WriteLine("Введите день");

            string day = Console.ReadLine();
            Console.WriteLine("Введите месяц");
            string mo = Console.ReadLine();
            Console.WriteLine("Введите год");
            string year = Console.ReadLine();
            string Datein = day + "-" + mo + "-"+ year;
            Console.WriteLine(Datein);
            DateTime.TryParse(Datein, out DateTime date);
            if (Regex.IsMatch(Datein, reg, RegexOptions.IgnoreCase))
            {
                Console.WriteLine("День недели:");
                Console.WriteLine(date.DayOfWeek); ;
                
            }
            else
            {
                Console.WriteLine("Некорректная дата");
            }
        }
        
    }
}

