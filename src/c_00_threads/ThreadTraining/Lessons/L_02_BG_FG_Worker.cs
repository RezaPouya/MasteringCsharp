namespace ThreadTraining.Lessons
{
    internal class L_02_BG_FG_Worker
    {
        
        public void Run()
        {
            Console.WriteLine($"Managed thread Id : {Thread.CurrentThread.ManagedThreadId}");


            // these are foreground thread , they won't shutdown
            // we can make the thread backgroud thread which is controlled by os 
            for (int i = 0; i < Environment.ProcessorCount; i++)
            {
                Thread thread = new Thread(DoSomething);

                thread.IsBackground = true;

                thread.Start();
            }

            Console.WriteLine($"Leaving Run");

        }

        private void DoSomething()
        {
            while(true)
                Console.WriteLine($"Hello From DoSemething {Thread.CurrentThread.ManagedThreadId}"); 
        }


        // Foreground thread : main threads , won't stop by os 
        // Background thread : 
    }
}