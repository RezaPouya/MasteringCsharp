namespace ThreadTraining.Lessons
{
    internal class L_03_SyncIssue
    {
        private static int count = 0; 
        private static object lockThread = new object();
        public static void Run()
        {
            var thread1 = new Thread(IncrementCount2);
            var thread2 = new Thread(IncrementCount2);
            thread1.Start();
            Thread.Sleep(500);
            thread2.Start();
        }

        static void IncrementCount()
        {
            while (true)
            {
                //count++;
                var temp = count;
                Thread.Sleep(1000);
                count = temp + 1;
                Console.WriteLine($"Thread Id {Thread.CurrentThread.ManagedThreadId} incremented count to {count}" );
                Thread.Sleep(1000);
            }
        }


        static void IncrementCount2()
        {
            while (true)
            {
                lock (lockThread)
                {
                    var temp = count;
                    Thread.Sleep(1000);
                    count = temp + 1;
                    Console.WriteLine($"Thread Id {Thread.CurrentThread.ManagedThreadId} incremented count to {count}");
                    Thread.Sleep(1000);
                }
               
            }
        }

        // count++ is not atomic operation , this is syntactic suger for count = count + 1; ( read , increment-add- , assing )

        // lock doesn't let another thread enter execution blocks ( and all variable there ) untill the first thread leave it 
    }
}