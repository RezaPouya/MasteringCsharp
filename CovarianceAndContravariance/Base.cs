using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CovarianceAndContravariance;

public class Base
{
    public Fruit GetFruit() => new Fruit();

    /// <summary>
    /// this is about covariance  - covariance is about output parameter 
    /// </summary>
    public virtual Fruit GetFruitVirtual() => new Fruit();

    /// <summary>
    /// this is about contravariance - contravariance is about input parameter 
    /// </summary>
    public string GetFruitName(Fruit fruit)
    {
        if (fruit is Orange)
            return nameof(Orange);

        return nameof(Fruit);
    }
}

public class Derived : Base
{
    public Orange GetFruit() => new Orange();

    public override Orange GetFruitVirtual() => new Orange();
}



public class Test
{
    public void TestIt()
    {
        var baseClass = new Base();

        var message = "is passed, the return type is ";

        var f = $"Fruit  {baseClass.GetFruitName(new Fruit())}";
        Console.WriteLine(f);

        var o = $"Orange {message} {baseClass.GetFruitName(new Orange())}";
        Console.WriteLine(o);

        var a = $"Apple {message} {baseClass.GetFruitName(new Apple())}";
        Console.WriteLine(a);
    }
}
