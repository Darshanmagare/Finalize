using System;
using System.Diagnostics;

namespace FinalizeMethod
{
    class ExClass
    {
        Stopwatch sw;

        public ExClass()
        {
            sw = Stopwatch.StartNew();
            Console.WriteLine("Instantiated object");
        }

        public void ShowDuration()
        {
            Console.WriteLine("This instance of {0} has been in existence for {1}",
                              this, sw.Elapsed);
        }

        ~ExClass()
        {
            Console.WriteLine("Finalizing object");
            sw.Stop();
            Console.WriteLine("This instance of {0} has been in existence for {1}",
                              this, sw.Elapsed);
        }
    }

    public class Demo
    {
        public static void Main()
        {
            ExClass ex = new ExClass();
            ex.ShowDuration();
        }
    }
}
