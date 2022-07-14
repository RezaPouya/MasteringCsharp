// See https://aka.ms/new-console-template for more information

public static class Program
{
    public static void Main()
    {
        var numbers = GetNumbers()
            .Where(p =>
            {
                return p % 2 == 0;
            })
            .Select(p =>
            {
                return p * 1.5;
            });

        var nums = numbers.ToList();

        foreach (var number in numbers)
        {
            Console.WriteLine(number);
        }

        Console.ReadLine();
    }

    private static IEnumerable<int> GetNumbers()
    {
        return Enumerable.Range(0, 100);
    }
}