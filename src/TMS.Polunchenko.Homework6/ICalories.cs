using System;

namespace TMS.Polunchenko.Homework6
{
    internal interface ICalories
    {
        public double Calories();

        public event Action<string> Notify;
    }
}