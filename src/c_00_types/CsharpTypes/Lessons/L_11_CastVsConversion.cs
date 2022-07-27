namespace CsharpTypes.Lessons;

internal static class L_11_CastVsConversion
{
    protected class Base
    {
        public int i;
    }

    protected class Derived : Base
    {
        public float f;

        
    }

    public static void Run()
    {
        // reference conversion 

        Derived d = new Derived();
        Base b = d; // reference conversion - just copy address of d in b 
        d = (Derived)b; // just saying compiler -> look at it as Derived 

        // cast at runtime , need cpu work 
        int i = 5;
        float f = i;
        i = (int)f; // this cast cause type conversion
    }
}
