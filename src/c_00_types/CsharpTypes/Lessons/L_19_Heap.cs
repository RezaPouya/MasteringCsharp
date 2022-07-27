namespace CsharpTypes.Lessons;

internal static class L_19_Heap
{
    internal class CountingClass
    {
        static short counter = 0;
        short id;
        char c;
        public CountingClass()
        {
            id = counter;
            c = (char)(((short)'a') + counter);
            counter++;
        }
    }

    public static void Run()
    {
        GC.Collect();
        var c1 = new CountingClass();
        var c2 = new CountingClass();
        var c3 = new CountingClass();
        var c4 = new CountingClass();
        new CountingClass();
        new CountingClass();
        var c5 = new CountingClass();
        var c6 = new CountingClass();
        GC.Collect();
    }

    // Garbage Collector:
    //      - change object position in memory and change refrence 
    //      - defrage memory
}