using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CovarianceAndContravariance;

internal class Program
{
    public void Main(string[] arg)
    {
        var baseClass = new Base();

        var message = "is passed, the return type is ";

        var f = $"Fruit  {baseClass.GetFruitName(new Fruit())}";
        Console.WriteLine(f);

        var o = $"Orange {message} {baseClass.GetFruitName(new Orange())}";
        Console.WriteLine(o);

        var a = $"Apple {message} {baseClass.GetFruitName(new Apple())}";
        Console.WriteLine(a);


        IEnumerable<Apple> derivedApples = new List<Apple>();
        IEnumerable<Fruit> fruits = derivedApples;

        
    }
}
