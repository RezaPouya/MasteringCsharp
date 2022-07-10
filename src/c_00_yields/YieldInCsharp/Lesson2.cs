using YieldInCsharp.OurCompilerSyntacticSugers;

public static class Lesson2
{
    private static IEnumerable<int> Numbers
    {
        get
        {
            Console.WriteLine("Begin");
            Console.WriteLine("yielding 1");
            yield return 1;
            Console.WriteLine("yielding 4");
            yield return 4;
            Console.WriteLine("yielding 2");
            yield return 2;
            Console.WriteLine("End !!! ");
        }
    }

    public static void Run1()
    {
        foreach (int i in Numbers)
        {
            Console.WriteLine(i);
        }
    }

    public static void Run2()
    {
        var numbers = new NumbersHybrid();

        foreach (int i in numbers)
        {
            Console.WriteLine(i);
        }
    }

    // This show how syntactic suger work for foreach
    public static void Run()
    {
        IEnumerable<int> source = new NumbersHybrid();
        IEnumerator<int> itrator = source.GetEnumerator();

        while (itrator.MoveNext())
        {
            Console.WriteLine(itrator.Current);
        }
    }
}