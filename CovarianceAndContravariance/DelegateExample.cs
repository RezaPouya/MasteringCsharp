using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CovarianceAndContravariance;

internal static class DelegateExample
{
    public delegate TResult Func<in T, out TResult>(T arg);

    public delegate Fruit HandlerMethod();
    public static Fruit FruitHandler() { return null; }
    public static Orange OrangeHandler() { return null; }
    static void CovarianceTest()
    {
        HandlerMethod h1 = FruitHandler;
        // Covariance makes the below assignment possible
        HandlerMethod h2 = OrangeHandler;
    }
    
    public static void ContraVarianceTest()
    {
        Action<Fruit> action1 =
            (target) => { Console.WriteLine(target.GetType().Name); };
        Action<Orange> action2 = action1;
        action2(new Orange());
    }
}
