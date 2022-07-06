using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CovarianceAndContravariance;

public class Base
{
    public Fruit GetFruit()
    {
        return new Fruit();
    }

    /// <summary>
    /// this is about covariance  - covariance is about output parameter 
    /// </summary>
    public virtual Fruit GetFruitVirtual()
    {
        return new Fruit();
    }

    /// <summary>
    /// this is about contravariance - contravariance is about input parameter 
    /// </summary>
    public string GetFruitName(Fruit fruit)
    {
        if (fruit is Apple)
            return nameof(Apple);

        if (fruit is Orange)
            return nameof(Orange);

        return nameof(Fruit);
    }
}


public class Derived : Base
{
    public Orange GetFruit()
    {
        return new Orange();
    }

    public override Orange GetFruitVirtual()
    {
        return new Orange();
    }
}
