using YieldInCsharp.OurCompilerSyntacticSugers;

public static class Lesson3
{
    private static Random random = new Random(Guid.NewGuid().GetHashCode());

    public static void Run()
    {
        foreach (int i in GetRandomNumbers())
        {
            Console.WriteLine(i);
        }
    }

    private static IEnumerable<int> GetRandomNumbers()
    {
        while (true)
        {
            int num = random.Next();

            if(num % 100 == 0)
                yield break;
            yield return num;
        }
    }
}