using YieldInCsharp;
using YieldInCsharp.OurCompilerSyntacticSugers;

public static class Lesson1
{
    private static Random random = new Random(Guid.NewGuid().GetHashCode());

    public static void Run()
    {
        foreach (int i in GetRandomNumbers2(10))
        {
            Console.WriteLine(i);
        }

        Console.WriteLine();
        Console.ReadLine();
    }

    private static IEnumerable<int> GetRandomNumbers(int count)
    {
        for (int i = 0; i < count; i++)
        {
            yield return random.Next();
        }
    }

    private static IEnumerable<int> GetRandomNumbers2(int count)
    {
        return new RundomNumberClass(count);
    }
}
