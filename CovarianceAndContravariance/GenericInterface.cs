namespace CovarianceAndContravariance;

internal interface GenericInterface<in T, out U>
{
    U Get(T input);
}

//internal class GenericClass<out T> where T : class
//{
//}
