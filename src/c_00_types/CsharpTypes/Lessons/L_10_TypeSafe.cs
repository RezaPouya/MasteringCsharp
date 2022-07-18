namespace CsharpTypes.Lessons;

internal static class L_10_TypeSafe
{
    protected class Base
    {
        public int Num { get; set; }
    }

    protected class Derived : Base
    {
        public float Fnum { get; set; }
    }

    public static void Run()
    {
        Base b = new Base ();
        Derived d = new Derived ();

        //long* ptr = &b;

        //Console.WriteLine(" Base Address", ptr);

        b = d; // float portion is still there but its hide 
        d = (Derived)b; // @base doesn't have float portion ? what should it do ? 
    }


    private static void Widening()
    {
        byte a1 = 5;
        byte a2 = 5;
        byte r = (byte)((int)a1 + a2); 
    }
}