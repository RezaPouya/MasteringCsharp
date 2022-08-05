using System.Diagnostics;

namespace ThreadTraining.Lessons
{
    internal class L_05_DivideAnConcure
    {
        private static object lockThread = new object();
        private static byte[] values = new byte[500000000];
        private static long[] portionResult;
        private static int portionSize;

        public static void Run()
        {
            portionResult = new long[Environment.ProcessorCount];
            portionSize = values.Length / Environment.ProcessorCount;
            GenerateInts();
            Console.WriteLine("Summing ... ");
            SequentialSum();
            ThreadedSum();
        }

        private static void GenerateInts()
        {
            Random random = new Random(10257);

            for (int i = 0; i < values.Length; i++)
            {
                values[i] = (byte)random.Next(10);
            }
        }

        private static void SequentialSum()
        {
            long total = 0;



            Stopwatch stopwatch = Stopwatch.StartNew();
            for (int i = 0; i < values.Length; i++)
            {
                total += values[i];
            }

            stopwatch.Stop();
            Console.WriteLine($"total : {total} ");
            Console.WriteLine($"Time of sum : {stopwatch.Elapsed}");
        }

        private static void ThreadedSum()
        {

            Stopwatch stopwatch = Stopwatch.StartNew();
            Thread[] threads = new Thread[Environment.ProcessorCount];
            for (int i = 0; i < Environment.ProcessorCount; i++)
            {
                threads[i] = new Thread(SumYourPortion);
                threads[i].Start(i);
            }

            for (int i = 0; i < Environment.ProcessorCount; i++)
            {
                threads[i].Join(); // i want to wait until you complete its job -- basic thread sychorinaztion
            }

            long total = 0;

            for (int i = 0; i < Environment.ProcessorCount; i++)
            {
                total += portionResult[i];
            }

            stopwatch.Stop();
            Console.WriteLine($"total : {total} ");
            Console.WriteLine($"Time of Threaded sum : {stopwatch.Elapsed}");
        }

        private static void SumYourPortion(object portionNumber)
        {
            long sum = 0;

            int portionNumberAsInt = (int)portionNumber;

            int baseIndex = portionNumberAsInt * portionSize;

            for (int i = baseIndex; i < baseIndex + portionSize; i++)
            {
                sum += values[i];
            }

            portionResult[portionNumberAsInt] = sum;
        }
    }
}