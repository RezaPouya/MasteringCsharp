using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CovarianceAndContravariance;

internal interface Generic<out T>
{
    public T ReturnObject(int x , int y);

    public void ReturnProp(T result);
}


internal class GenericClass<out T> where T : class
{
}
