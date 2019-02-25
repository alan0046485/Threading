using System;
using System.Threading;

namespace Threading
{
    class Program
    {
        public static void CallToChildThread()
        {
            Console.WriteLine("Child thread starts");
            for (int i =1; i < 10000; i++)
            {
                Console.WriteLine(i);
                Thread.Sleep(100);
            }
            int sleepfor = 5000;
            Console.WriteLine("Child Thread Paused for {0} seconds", sleepfor / 1000);
            Thread.Sleep(sleepfor);
            Console.WriteLine("Child thread resumes");
        }

        // the thread is paused for 5000 milliseconds
        

        static void Main(string[] args)
        {
            ThreadStart childref = new ThreadStart(CallToChildThread);
            Console.WriteLine("In Main: Creating the Child thread");
            Thread childThread = new Thread(childref);
            Console.WriteLine("In main: Starting the Child Thread");
            childThread.Start();
            Console.WriteLine("Waiting for exit key");
            Console.ReadKey();


            Thread th = Thread.CurrentThread;
            th.Name = "MainThread";

            Console.WriteLine("This is {0}", th.Name);
            Console.ReadKey();


        }
    }
}
