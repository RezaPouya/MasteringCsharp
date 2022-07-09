namespace CovarianceAndContravariance;

public interface IDish<out T>
{
    public T Get();

    // ERROR:: Invalid variance: The type parameter 'T' must be contravariantly valid on 'IBasket<T>.Add(T)'. 'T' is covariant.
    //public void Cut(T item);
}

public class OrangeDish : IDish<Orange>
{
    public Orange Get() => null;
}

public static class ProccessDish
{
    private static void Process(IDish<Fruit> fruitDish)
    {
    }

    public static void DoProcess()
    {
        IDish<Orange> orangeDish = new OrangeDish();

        Process(orangeDish);
    }
}