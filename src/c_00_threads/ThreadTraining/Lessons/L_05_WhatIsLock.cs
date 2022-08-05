namespace ThreadTraining.Lessons
{
    internal class L_05_WhatIsLock
    {
        private static object lockThread = new object();
        private static Random random = new Random(Guid.NewGuid().GetHashCode());

        public static void Run()
        {
            lock (lockThread)
            {
                Console.WriteLine("I entered the lock ");
            }
        }

        private static void DoSomething()
        {
           
            //lock (lockThread)
            //{
            //}
            // this is equivelant to below code 


            bool lockTaken = false;
            Monitor.Enter(lockThread , ref lockTaken);
            try
            {
                Console.WriteLine("I entered the lock ");
            }
            finally
            {
                if(lockTaken)
                    Monitor.Exit(lockThread);
            }
         
        }


        private static void DoSomething2()
        {

            lock (lockThread)
            {
                Console.WriteLine("I entered the lock ");
            }
            // this is equivelant to below code 
        }
    }

    // lock is native C# syntactic suger 
}
