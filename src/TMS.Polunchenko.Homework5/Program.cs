using System;

namespace TMS.Polunchenko.Homework5
{
    class Program
    {
        static void Main(string[] args)
        {
            Bankomat bankomat = new Bankomat();
            bankomat.Notify += Display;//empty
        
            var putsalary = Salary();
            bankomat.Enrollment(putsalary);
            Console.WriteLine();
            bankomat.Writting(50);
            Console.WriteLine();
            bankomat.Writting(500);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("=============================================");

            Console.WriteLine($"Oстаток на {DateTime.Now} : {bankomat.Sum}руб");
            Console.ResetColor();
        }
        static int Salary()
        {
            Console.WriteLine("Вы получили зарплату!");
           var salary = 500;
            return salary;


        }
        private static void Display(string str)
        {
            Console.WriteLine(str); ;
        }
    }


}
