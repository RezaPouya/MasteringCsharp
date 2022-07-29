namespace CsharpTypes.Lessons;

internal static class L_24_StaticConstructor
{
    internal class TestClass
    {
        protected static int constructorInt;
        static TestClass()
        {
            constructorInt =  (++constructorInt) * 6 ;
        }

        public void PrintStaticMemeberValue()
        {
            Console.WriteLine(constructorInt);
        }
    }

    public static void Run()
    {
        var obj1 = new TestClass();
        obj1.PrintStaticMemeberValue();
        var obj2 = new TestClass();
        obj2.PrintStaticMemeberValue();
        var obj3 = new TestClass();
        obj3.PrintStaticMemeberValue();
    }
}


// it will be called the first time the type is called  // it only run once 
// static constructor is .net framework concept not C# exclusive 
// all static member are initialized in static constructors
// static class doesnt have any instance , they are just in static part of memory (RAM)


// During compile time, the compiler makes a static analysis (fancy word for compile-time analysis) of a variable's declared type.
// At runtime, an actual instance is created and assigned to the variable (hence, runtime).
