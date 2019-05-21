using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleClock
{
    class Program
    {
        static void Main(string[] args)
        {
            Program prog = new Program();
            ThreadStart Ts = new ThreadStart(prog.showClock);
            Thread T = new Thread(Ts);
            T.Start();
            Console.ReadLine();
        }

        public void showClock()
        {
            for(;;)
            {
                Console.WriteLine(DateTime.Now.ToString());
                Console.WriteLine("\a");

                Thread.Sleep(1000);

                Console.Clear();
            }
        }


    }
}
