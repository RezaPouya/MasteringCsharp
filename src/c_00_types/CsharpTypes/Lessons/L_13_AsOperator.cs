namespace CsharpTypes.Lessons;

internal static class L_13_AsOperator
{
    protected class Base
    {
    }

    protected class Derived : Base
    {
    }

    public static void Run()
    {
        var random = new Random(Guid.NewGuid().ToString().GetHashCode());
        var randomBool = random.Next() % 2 == 0;
        
        Base b = randomBool ?  new Base() : new Derived();
        Derived d =(Derived)b; // if b is Base  : Exception :  'Unable to cast object of type 'Base' to type 'Drived'.'

        Base b2 =  new Base() ;
        Derived d2 = b2 as Derived; // if you can cast b to derived , do it , if not , then not throw exception and return null 



        if (d2 is null)
            Console.WriteLine("oh b is not object");
        //Console.WriteLine($"type of b {b.GetType()}");
        //Console.WriteLine($"d {d}");
    }
}
