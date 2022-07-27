using System.Runtime.InteropServices;

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

    public static unsafe void Run()
    {
        Base b = new Base();
        Derived d = new Derived();

        GCHandle handle = GCHandle.Alloc(b.Num, GCHandleType.Pinned);
        IntPtr pointer_a_num = GCHandle.ToIntPtr(handle);

        GCHandle handled = GCHandle.Alloc(b.Num, GCHandleType.Pinned);
        IntPtr pointer_d_num = GCHandle.ToIntPtr(handled);

        //int* ptr = &(b.Num);
        b = d; // float portion is still there but its hide

        GCHandle handle2 = GCHandle.Alloc(b.Num, GCHandleType.Pinned);
        IntPtr pointer_a_num2 = GCHandle.ToIntPtr(handle2);

        d = (Derived)b; // @base doesn't have float portion ? what should it do ?

        GCHandle handle3 = GCHandle.Alloc(b.Num, GCHandleType.Pinned);
        IntPtr pointer_a_num3 = GCHandle.ToIntPtr(handle2);

        Console.WriteLine(" Base Address a.num : " + pointer_a_num.ToString());
        Console.WriteLine(" Base Address d.num : " + pointer_d_num.ToString());
        Console.WriteLine(" Base Address a(d.num) : " + pointer_a_num2.ToString());
        Console.WriteLine(" Base Address d(b.num) : " + pointer_a_num3.ToString());


    }

    private static void Widening()
    {
        byte a1 = 5;
        byte a2 = 5;
        byte r = (byte)((int)a1 + a2);
    }
}