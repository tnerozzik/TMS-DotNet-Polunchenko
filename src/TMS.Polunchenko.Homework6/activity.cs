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
        public double  Calories { get; set; }
        public void  GetCalories()
        {
            if (Pulse > 130)
            {
                 Calories = Distance * Weight * 1.2;
                Math.Ceiling(Calories);

                Notify?.Invoke("Пульс выше 130 ударов");
                

                Notify?.Invoke("Pulse above 130 beats");
             }
            else
            {
                 Calories = Distance * Weight;
          
            }
        }
    }

    public class Yoga : Activity, ICalories
    {
        public event Action<string> Notify;

        public int Time { get; set; }
        public int Pulse { get; set; }
        public double Calories { get; set; }

        public void GetCalories()
        {
            if (Pulse > 130)
            {

                Calories = Time * Weight / 10 * 1.2;
                Notify?.Invoke("Пульс выше 130 ударов");
               

                 Calories = Time * Weight / 10 * 1.2;
                Notify?.Invoke("Pulse above 130 beats");
               

            }
            else
            {
                 Calories = Time * Weight / 10;
                
            }
        }
    }
}