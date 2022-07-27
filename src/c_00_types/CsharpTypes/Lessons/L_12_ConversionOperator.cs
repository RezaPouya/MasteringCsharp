namespace CsharpTypes.Lessons;

internal static class L_12_ConversionOperator
{
    protected class Scooter
    {
        public int Millage { get; set; }

        // this is just a method !!! nothing more than syntactic suger
        public static implicit operator Car(Scooter scooter)
        {
            return new Car
            {
                Millage = scooter.Millage,
            };
        }
    }

    protected class Car
    {
        public int Millage { get; set; }
    }

    public static void Run()
    {
        Scooter scooter = new Scooter();
        Car car = scooter; // this is type conversion --- need work to be done
        object o = scooter; // this is reference conversio --- doesnt need work to be done -- hey compiler copy of scooter address to o
    }
}
