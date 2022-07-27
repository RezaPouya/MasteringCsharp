namespace CsharpTypes.Lessons;

internal static class L_22_StaticVariable
{
    internal class Cow
    {
        public static int numInstance; // this is shared among all objects 
        public int id;
        public Cow()
        {
            id = ++numInstance;
        }
    }
    public static void Run()
    {
        Cow betsy = new Cow();
        Cow georgy = new Cow();
        Console.WriteLine($"betsy {betsy.id}");
        Console.WriteLine($"georgy {georgy.id}");
    }
    /// static variable is something that shared among all object 
    /// 
    /// where numinstance is ? 
    /// they are part of program which will be load on when progam is loading .
    /// they are allocated on compile time .
    /// 
    /// we have 3 part in memory 
    /// Stack (mutable)   - dynamic memory
    /// heap  (mutable)   - dynamic memory
    /// static-bloc (immutable-size) - static memory ( compile-time) .... 
    /// exist before main 
    /// exist after main 
    /// only shut down when the process i s closed 
}
