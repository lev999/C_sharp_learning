using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace myFirstProject
{

    class TimePeriod
    {
        private double seconds;
        public double Hours
        {
            get { return seconds / 3600; }
            set { seconds = value * 3600; }
        }
    }


    class Program
    {
        static void Main()
        {
            TimePeriod t = new TimePeriod();

            // Assigning the Hours property causes the 'set' accessor to be called.
            t.Hours = 24;

            // Evaluating the Hours property causes the 'get' accessor to be called.
            Console.WriteLine("Time in hours: " + t.Hours);
            Console.ReadKey();
        }
    }
}
