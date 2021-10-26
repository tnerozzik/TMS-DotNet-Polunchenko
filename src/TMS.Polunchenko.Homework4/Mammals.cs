using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMS.Polunchenko.Homework4
{
    public class Mammals:Animal,IClinning
    {
        public List<MammalsSp> Mammalss { get; set; }
        public void Cliner()
        {
            Console.WriteLine("Вольеры животных на уборке");
        }
    }
}
