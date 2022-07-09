namespace CovarianceAndContravariance;

public interface IBasket<in T>
{
    public void Add(T item);

    // ERROR : Invalid variance: The type parameter 'T' must be covariantly valid on 'IBasket<T>.Return(T)'. 'T' is contravariant.
    //public T Return(T item);
}

public class FruitBasket : IBasket<Fruit>
{
    private Fruit _fruit;

    public void Add(Fruit item)
    {
        if (_fruit is null)
            _fruit = item;
    }
}

public static class ProccessBasket
{
    private static void Process(IBasket<Orange> basket)
    {
    }

    public static void DoProcess()
    {
        IBasket<Fruit> basket = new FruitBasket();

        Process(basket);
    }
}