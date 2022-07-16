using CsharpTypes.SyntacticSugers;

namespace CsharpTypes.Lessons;

internal static class L_08_NullableTypes
{
    private static int? PayTax()
    {
        return null;
    }

    public static void Run()
    {
        int? tax = PayTax();
        Nullable<int> tax2 = PayTax();

        int? i = 6;

        Nullable<int> i2 = new Nullable<int>(6);
        MyNullable<int> m = new MyNullable<int>(2);

        i2 = null;
        m = new MyNullable<int>();

        //----------------------
        MyNullable<int> x = new MyNullable<int>(2);
        MyNullable<int> y = new MyNullable<int>(2);

        //var z = x + y; //

        // whats compiler actually do
        var z = (x.HasValue && y.HasValue) ?
            new MyNullable<int>(x.Value + y.Value) :
            new MyNullable<int>();

        // i + null = null

        int? f = null;
        int? g = null;
        Console.WriteLine(f == g);
    }

    // nullable are C# vip member which the compiler turn them to actuall running code by itself
    // using ? mark in reality slow down your codes, so be aware of it
}