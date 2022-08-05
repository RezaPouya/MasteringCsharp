namespace ThreadTraining.Lessons
{
    internal class L_00_Thread
    {
        // if we run this , nothing will print , because main thread is diffrent from our created thread
        public void Run()
        {
            Thread thread = new Thread(() => DoSomething());
            thread.Start();
        }

        private void DoSomething()
        {
            Console.WriteLine("Hello World");
        }
    }
}