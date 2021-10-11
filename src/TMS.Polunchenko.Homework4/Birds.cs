using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMS.Polunchenko.Homework4
{
    public class Birds:Animal,IClinning
    {  
       public List <BirdsSp> Birdss { get; set; }
        public void Cliner()
        {
            Console.WriteLine("Вольеры птиц на уборке");
        }
    }
}
