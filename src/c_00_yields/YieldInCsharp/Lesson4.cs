using YieldInCsharp.OurCompilerSyntacticSugers;

public static class Lesson4
{
    private static Random random = new Random(Guid.NewGuid().GetHashCode());

    public static void Run()
    {
        var numbers = new NumbersHybridWithException();

        foreach (int i in numbers)
        {
            Console.WriteLine(i);
        }
    }

    
}