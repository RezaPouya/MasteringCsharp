namespace CovarianceAndContravariance;

public static class BCLExamples
{
    public static void CovarianceExample()
    {
        IEnumerable<Orange> oranges = new List<Orange>();
        IEnumerable<Fruit> fruits = oranges;
    }

    public static void ContravarianceExample()
    {
        IComparer<Fruit> fruitComparer = new FruitComparer();
        IComparer<Orange> orangeComparer = fruitComparer;
    }
}

public class FruitComparer : IComparer<Fruit>
{
    public int Compare(Fruit? x, Fruit? y)
    {
        throw new NotImplementedException();
    }
}