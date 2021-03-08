using System;
using System.Threading;
using System.Threading.Tasks;

namespace Asynchronous
{
    class Program
    {
        /// <summary>
        /// Action instantiation
        /// </summary>
        /// <returns></returns>
        /*
        public static void Main(string[] args)
        {
            Action<object> action = (object obj) =>
            {
                Console.WriteLine("Task={0}, obj={1}, thread={2}",
                Task.CurrentId, obj,
                Thread.CurrentThread.ManagedThreadId);
            };
            Task t1 = new Task(action, "alpha");

            Task t2 = Task.Factory.StartNew(action, "beta");
            t2.Wait();

            t1.Start();
            Console.WriteLine("t1 has been launched. (Main Thread={0})",
                              Thread.CurrentThread.ManagedThreadId);
            t1.Wait();

            String taskData = "delta";
            Task t3 = Task.Run(() => {
                Console.WriteLine("Task={0}, obj={1}, Thread={2}",
                                  Task.CurrentId, taskData,
                                   Thread.CurrentThread.ManagedThreadId);
            });
            t3.Wait();

            Task t4 = new Task(action, "gamma");
            t4.RunSynchronously();
            t4.Wait();
        }
        */


        /// <summary>
        /// executing a task
        /// </summary>
        /// <returns></returns>
        /*
        public static async Task Main()
        {
            await Task.Run(() => {
                int ctr = 0;
                for (ctr = 0; ctr <= 1000000; ctr++)
                { }
                Console.WriteLine("Finished {0} loop iterations",
                                  ctr);
            });
        }
        */


        /// <summary>
        /// Waiting for one or more tasks to complete
        /// </summary>
        /*
        static Random rand = new Random();
        static void Main()
        {
            Task taskA = Task.Run(() => Thread.Sleep(5000));
            Console.WriteLine("taskA Status: {0}", taskA.Status);
            try
            {
                taskA.Wait();
                Console.WriteLine("taskA Status: {0}", taskA.Status);
            }
            catch (AggregateException)
            {
                Console.WriteLine("Exception in taskA.");
            }
        }
        */


        /// <summary>
        /// Waiting for one or more tasks to complete (The Wait(Int32) and Wait(TimeSpan))
        /// </summary>
        /*
        public static void Main()
        {
            // Wait on a single task with a timeout specified.
            Task taskA = Task.Run(() => Thread.Sleep(2000));
            try
            {
                taskA.Wait(1000);       // Wait for 1 second.
                bool completed = taskA.IsCompleted;
                Console.WriteLine("Task A completed: {0}, Status: {1}",
                                 completed, taskA.Status);
                if (!completed)
                    Console.WriteLine("Timed out before task A completed.");
            }
            catch (AggregateException)
            {
                Console.WriteLine("Exception in taskA.");
            }
        }
        */


        /// <summary>
        /// Waiting for one or more tasks to complete Wait(CancellationToken) and Wait(Int32, CancellationToken)
        /// </summary>
        /*
        public static void Main()
        {
            var tasks = new Task[3];
            var rnd = new Random();
            for (int ctr = 0; ctr <= 2; ctr++)
                tasks[ctr] = Task.Run(() => Thread.Sleep(rnd.Next(500, 3000)));

            try
            {
                int index = Task.WaitAny(tasks);
                Console.WriteLine("Task #{0} completed first.\n", tasks[index].Id);
                Console.WriteLine("Status of all tasks:");
                foreach (var t in tasks)
                    Console.WriteLine("   Task #{0}: {1}", t.Id, t.Status);
            }
            catch (AggregateException)
            {
                Console.WriteLine("An exception occurred.");
            }
        }
        */


        /// <summary>
        /// Waiting for one or more tasks to complete WaitAll method
        /// </summary>
        /*
        public static void Main()
        {
            // Wait for all tasks to complete.
            Task[] tasks = new Task[10];
            for (int i = 0; i < 10; i++)
            {
                tasks[i] = Task.Run(() => Thread.Sleep(2000));
            }
            try
            {
                Task.WaitAll(tasks);
            }
            catch (AggregateException ae)
            {
                Console.WriteLine("One or more exceptions occurred: ");
                foreach (var ex in ae.Flatten().InnerExceptions)
                    Console.WriteLine("   {0}", ex.Message);
            }

            Console.WriteLine("Status of completed tasks:");
            foreach (var t in tasks)
                Console.WriteLine("   Task #{0}: {1}", t.Id, t.Status);
        }
        */



    }
}
