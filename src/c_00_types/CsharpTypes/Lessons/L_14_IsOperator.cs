namespace CsharpTypes.Lessons;

internal static class L_14_IsOperator
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

        Base b = randomBool ? new Base() : new Derived();
        Derived d = null;

        if (b is Derived) // is have some runtime check - 'as' has more performance 
            d = (Derived)b;

        if (d is null)
            Console.WriteLine("oh b is not object");
        else
            Console.WriteLine("we have an object");


        // is -> this is RTTI ( Run time check ) 
    }
}