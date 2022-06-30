namespace CovarianceAndContravariance
{
    public class Covariance
    {
        /// <summary>
        /// more derived type component can be assigned to a less derived type component
        /// </summary>
        public void Test()
        {
            Fruit fruit = new Fruit();
            Apple apple = new Apple();

            fruit = apple;
            apple = fruit; // it has error because we can't add less derived type to more derived type
        }
    }
}