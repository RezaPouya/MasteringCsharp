using System.Runtime.InteropServices;

namespace CsharpTypes.Lessons;

internal static class L_16_AlignmentAndPacking
{
    protected class AClass
    {
        public int int1; // 4 byte
        public char char1; // 2 byte
        public char char2; // 2 byte

        // the bigest alignment is int 
        // 4 
        // 2 - 2 ( packing) 
        // total-content size => 8
    }

    protected struct AClass2
    {
        public char char1;
        public int int1;
        public char char2;

        // the bigest alignment is int 
        // 4
        // 4 
        // 4 

        // total-content size => 12
    }

    [StructLayout(LayoutKind.Auto)] // we can tell compiler how to align and pack struct 
    protected struct AClass3
    {
        public char char1;
        public int int1;
        public char char2;
    }

    [StructLayout(LayoutKind.Explicit)] // we can tell compiler how to align and pack struct 
    protected struct AClass4
    {
        [FieldOffset(0)]
        public char char1;

        [FieldOffset(44)]
        public int int1;

        [FieldOffset(4)]
        public char char2;
    }

    public static void Run()
    {
        var aClass = new AClass();
        aClass.int1 = 1;
        aClass.char1 = 'a';
        aClass.char2 = 'b';
        //unsafe
        //{
        //    Console.WriteLine(sizeof(AClass));
        //}

        unsafe
        {
            Console.WriteLine(sizeof(AClass2));
            Console.WriteLine(sizeof(AClass3));
            Console.WriteLine(sizeof(AClass4));
        }
    }

    // the alignmet for 'AClass' is equal to its widest member which in this case is 'int1'
    // sizeof() is compile-time , so it cannot get sizeof manage type 
}

