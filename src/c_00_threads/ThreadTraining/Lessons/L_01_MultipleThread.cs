namespace ThreadTraining.Lessons
{
    internal class L_01_MultipleThread
    {
        public void Run()
        {
            for (int i = 0; i < 4; i++)
            {
                Thread thread = new Thread(DoSomething);

                // here , we will send i ( thread number ) to delegated method 
                thread.Start(i);
            }
         
        }

        private void DoSomething(object threaId)
        {
            while(true)
                Console.WriteLine($"Hello From DoSemething {threaId}"); 
        }
    }
}