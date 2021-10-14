using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMS.Polunchenko.Homework5
{
    class Bankomat
    {
        int sum;
        public event Action<string> Notify;


        public int Sum
        { 
            get
            {
                return sum;
            }
        }

        public void  Enrollment (int _sum)
        {
            sum +=_sum;
            Console.ForegroundColor = ConsoleColor.Green;
            Notify?.Invoke($"Успешно!\nПополнение счета {_sum}руб");

        }
        public void Writting (int _sum)
        {   if (_sum > sum)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Notify?.Invoke($"Ошибка!\nНедостаточно средств");
            }
            else
            {
                sum = sum - _sum;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"Успешно!\nЗаберите Ваши деньги\n -{_sum}руб на счету"); 
            }

        }


    }
}
