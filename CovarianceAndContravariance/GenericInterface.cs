namespace CovarianceAndContravariance;

internal interface GenericInterface<in T, out U>
{
    U Get(T input);
}