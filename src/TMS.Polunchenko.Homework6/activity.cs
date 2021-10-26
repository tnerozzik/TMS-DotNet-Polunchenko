using System;

namespace TMS.Polunchenko.Homework6
{
    public class Activity
    {
        public int Weight { get; set; }
    }

    public class Run : Activity, ICalories
    {
        public event Action<string> Notify;

        public int Distance { get; set; }
        public int Pulse { get; set; }

        public double Calories()
        {
            if (Pulse > 130)
            {
                double Calories = Distance * Weight * 1.2;
                Math.Ceiling(Calories);
                Notify?.Invoke("Pulse above 130 beats");
                return Calories;
            }
            else
            {
                double Calories = Distance * Weight;
                return Calories;
            }
        }
    }

    public class Yoga : Activity, ICalories
    {
        public event Action<string> Notify;

        public int Time { get; set; }
        public int Pulse { get; set; }

        public double Calories()
        {
            if (Pulse > 130)
            {
                double Calories = Time * Weight / 10 * 1.2;
                Notify?.Invoke("Pulse above 130 beats");
                return Calories;
            }
            else
            {
                int Calories = Time * Weight / 10;
                return Calories;
            }
        }
    }
}