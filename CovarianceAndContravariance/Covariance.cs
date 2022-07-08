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
            Orange orange = new Orange();
            Apple apple = new Apple();


            fruit = apple;
            fruit = orange;
            PrintFruit(fruit);
            PrintFruit(apple);
            PrintFruit(orange);

            // ERROR : these have errors because we can't add less derived type to more derived type
            //PrintApple(orange);
            //PrintApple(fruit);
            //orange = apple;
            //apple = fruit; 
        }

        private void PrintFruit(Fruit fruit)
        {
            Console.WriteLine($"Fruit => {fruit.GetType()}");
        }

        private void PrintOrange(Orange orange)
        {
            Console.WriteLine($"Orange => {orange.GetType()}");
        }

        private void PrintApple(Apple apple)
        {
            Console.WriteLine($"Apple => {apple.GetType()}");
        }
    }
}