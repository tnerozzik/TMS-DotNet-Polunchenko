using System;

namespace TMS.Polunchenko.Homework6
{
    internal interface ICalories
    {
        public void GetCalories();

        public event Action<string> Notify;
    }
}