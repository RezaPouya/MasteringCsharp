namespace ThreadTraining.Lessons
{
    internal class L_04_LockExample
    {
        private static object lockThread = new object();
        private static Random random = new Random(Guid.NewGuid().GetHashCode());

        public static void Run()
        {
            for (int i = 0; i < Environment.ProcessorCount; i++)
            {
                var threadTask = new Thread(DoSomething);
                threadTask.Start();
            }
        }

        private static void DoSomething()
        {
            Console.WriteLine($"{Thread.CurrentThread.ManagedThreadId} : Trying to obtain lock and do its bussiness.");

            lock (lockThread)
            {
                Console.WriteLine($"{Thread.CurrentThread.ManagedThreadId} : obtained the lock. Doin my bussiness ... ");
                Thread.Sleep(random.Next(2000));
                Console.WriteLine($"{Thread.CurrentThread.ManagedThreadId} : leaving the stall !!! ");
            }

            Console.WriteLine($"{Thread.CurrentThread.ManagedThreadId} : leaving the method  ");
        }
    }

    // the firest example is in previous lesson
}
