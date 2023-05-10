using CodeWithParveenYadav.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace CodeWithParveenYadav.Service
{
    

    class ThreadProgramming
    {
        public void PerformTask1(object name)
        {
            var a = (PersonDto) name;

            for (var i = 0; i < 100000; i++)
            {
                Console.WriteLine($"Performing Task1 :: { a.FirstName }");
            }

            Console.WriteLine("Worker Thread Quits..!");
        }

        public void PerformTask2(object name)
        {
            for (var i = 0; i < 1000; i++)
            {
                Console.WriteLine($"PerformTask2 ::  { i }, Current Thread ; { Thread.CurrentThread.ManagedThreadId } ");
            }
        }

        public void PerformTask3()
        {
            for (var i = 0; i < 10000; i++)
            {
                Console.WriteLine("Task3 ::: Performing Task3");
                Thread.Sleep(4000); //Sleep for 4 seconds
            }

        }
    }
}
