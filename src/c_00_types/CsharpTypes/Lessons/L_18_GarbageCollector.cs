namespace CsharpTypes.Lessons;

internal static class L_18_GarbageCollector
{
    internal class Wrapper
    {
        public int WrapperInt; 
    }
    public static void Run()
    {
        var wrapper1 = new Wrapper();
        var wrapper2 = new Wrapper();
        var wrapper3 = new Wrapper();
        var wrapper4 = new Wrapper();
        wrapper1.WrapperInt = 1;
        wrapper2.WrapperInt = 2;
        wrapper3.WrapperInt = 3;
        GC.Collect();
        wrapper2 = null;
        GC.Collect();
    }

    // Garbage Collector:
    //      - change object position in memory and change refrence 
    //      - defrag memory
}