using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace ThreadingDemo
{
    class ISAliveDemo
    {
        static void M1()
        {
            Thread.Sleep(3000);
            Console.WriteLine("Sleep State =" + Thread.CurrentThread.ThreadState);
        }

        static void M2()
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Print  i{0} ", i);
                Console.WriteLine("Thread name " + Thread.CurrentThread.Name);

                Thread.Sleep(200);
            }

        }
        static void Main(string[] args)
        {
            ThreadAliveAndStates();


           Console.ReadLine();



        }

        private static void ThreadAliveAndStates()
        {
            Thread t1 = new Thread(M1);
            Thread t2 = new Thread(M1);
            Console.WriteLine("----Before Start---- ");
            Console.WriteLine("Is T1 alive= " + t1.IsAlive);
            Console.WriteLine("Is T2 alive= " + t2.IsAlive);
            Console.WriteLine("Thread state T1= " + t1.ThreadState);
            Console.WriteLine("Thread state T2= " + t2.ThreadState);

            t1.Start();
            t2.Start();
            Console.WriteLine("----After Start----");
            Console.WriteLine("Is T1 alive= " + t1.IsAlive);
            Console.WriteLine("Is T2 alive= " + t2.IsAlive);
            Console.WriteLine("Thread state T1= " + t1.ThreadState);
            Console.WriteLine("Thread state T2= " + t2.ThreadState);

            t1.Abort();
            t2.Abort();
            Console.WriteLine("Thread state T1= " + t1.ThreadState);
            Console.WriteLine("Thread state T2= " + t2.ThreadState);
        }
    }
}
//***------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace ThreadingDemo
{
    class SyncDemoUsingLock
    {
        void PrintTable()
        {
            lock (this)
            {
                for (int i = 1; i <= 10; i++)
                {
                    Thread.Sleep(100);
                    Console.WriteLine(i);

                }
            }
        }
        static void Main(string[] args)
        {
            SyncDemoUsingLock l = new SyncDemoUsingLock();
            Thread t1 = new Thread(l.PrintTable);
            Thread t2 = new Thread(l.PrintTable);
            t1.Start();
            t2.Start();
            Console.Read();


        }
    }
}
//------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace ThreadingDemo
{
    class SemaphoreDemo
    {
        static Thread[] threads = new Thread[10];
        static Semaphore sem = new Semaphore(3, 3);
        static void M1()
        {
            Console.WriteLine("{0} is waiting in line...", Thread.CurrentThread.Name);
            sem.WaitOne();
            Console.WriteLine("{0} enters the code", Thread.CurrentThread.Name);
            Thread.Sleep(300);
            Console.WriteLine("{0} is leaving the code", Thread.CurrentThread.Name);
            sem.Release();
        }
        static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++)
            {
                threads[i] = new Thread(M1);
                threads[i].Name = "thread_" + i;
                threads[i].Start();
            }
            Console.Read();
        }
    }
}
//------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace ThreadingDemo
{
    class Threadtypes
    {
        static void MyThreadMethod()
        {
            Console.WriteLine("The current thread which is running = " + Thread.CurrentThread.Name);
            for (int i = 0; i <= 3; i++)
            {
                Console.WriteLine("Method {0} =", i);
                Thread.Sleep(1000);
            }
            Console.WriteLine("My thread Method ends");
        }
        static void Main(string[] args)
        {

            Thread t1 = new Thread(MyThreadMethod);
            t1.Name = "MyThread";
            //  t1.IsBackground = true;
            t1.Start();
            Console.WriteLine("Main thread ends");
            Thread.Sleep(2000);
            t1.Abort();
            Console.WriteLine("thread aborted");
            Console.ReadLine();
        }
    }
}
//--------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadingDemo
{
    class DeadlockDemo
    {
        static object lock1 = new object();
        static object lock2 = new object();
        static void Job1()
        {
            lock (lock1)
            {
                Job2();
                Console.WriteLine("This is job1");
                lock (lock2)
                {
                    Job2();
                    Console.WriteLine("Job2 locked");
                }
            }
        }
        static void Job2()
        {
            lock (lock2)
            {
                Job1();
                Console.WriteLine("This is Job2");
            }



        }
        static void Main(string[] args)
        {
            Thread t1 = new Thread(Job1);
            Thread t2 = new Thread(Job2);
            t1.Start();
            t2.Start();
            t2.Abort();
            Console.WriteLine("Aborted");
            Console.Read();
        }
    }
}