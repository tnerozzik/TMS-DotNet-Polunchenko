using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMS.Polunchenko.Homework4
{   /// <summary>
    /// absract class
    /// </summary>
    public abstract class Animal
    {
        public char Sex { get; set; }
        public int Age { get; set; }
        public string PlaceofBirth { get; set; }

        public int AviaryNumber { get; set; }
    }
}
