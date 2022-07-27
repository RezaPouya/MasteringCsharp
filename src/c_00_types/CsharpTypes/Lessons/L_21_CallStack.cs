namespace CsharpTypes.Lessons;

internal static class L_21_CallStack
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
        Recursive(3);
    }

    public static void Recursive(int i)
    {
        CountingClass c = new CountingClass();
        if (i == 0)
            return;
        Recursive(i - 1);
    }

    /// when you call a method , you actually instantiate a method ( allocate memory on stack ) 
    ///  each call to method , create a seperate call-stack  .. another name for 'stack-frame' is 'activation-stack'
}
