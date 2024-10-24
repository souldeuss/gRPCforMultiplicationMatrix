using System;
using System.Threading;

namespace Lab_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var pTrread = new Thread(new ParameterizedThreadStart(Count));

            pTrread.Start(5);

            for (int i = 1; i < 10; i++)
            {
                Console.WriteLine("Main thread iteration: " + i);
                Thread.Sleep(300);
            }
        }

        static void Count(object o)
        {
            int x = (int)o;
            for (int i = 1; i < 10; i++)
            {
                Console.WriteLine("Secondary thread iteration: " + i);
                Thread.Sleep(400);
            }
        }
    }
}
//var currentThread = Thread.CurrentThread;

//Console.WriteLine($"Name : {currentThread.Name ?? "Name is not set"}");
//currentThread.Name = "Default Main";
//Console.WriteLine($"Name : {currentThread.Name ?? "Name is not set"}");

//Console.WriteLine($"Is Alive : {currentThread.IsAlive}");
//Console.WriteLine($"Is Background : {currentThread.IsBackground}");
//Console.WriteLine($"Priority : {currentThread.Priority}");
//Console.WriteLine($"Thread State : {currentThread.ThreadState}");

//Console.WriteLine($"App domain: {Thread.GetDomain().FriendlyName}");
        //    Thread thread = new Thread(new ThreadStart(Count));

        //    thread.Start();

        //    for (int i = 1; i < 10; i++)
        //    {
        //        Console.WriteLine("Main thread: " + i);
        //        Thread.Sleep(300);
        //    }
        //}

        //static void Count()
        //{
        //    for (int i = 1; i < 10; i++)
        //    {
        //        Console.WriteLine("Secondary thread: " + i);
        //        Thread.Sleep(400);
        //    }