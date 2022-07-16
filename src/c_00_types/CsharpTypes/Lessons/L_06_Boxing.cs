namespace CsharpTypes.Lessons;

/// <summary>
/// boxing is important because it can reduce your performance
/// boxing turn value type in object and object should be referenced in heap 
/// </summary>
///
internal static class L_06_Boxing
{
    public static void Run()
    {
        int i = 5;
        object o = i;
        i = 20;
        Console.WriteLine(o);
        Console.WriteLine(i);
        o = 99; // this will make new box , the unrefrence box(5) is going to get GC
        Console.WriteLine(o);

        // modifying the boxed value 
        object c = 5;
        //c++; // error , we can't do ++ on object 
             

        //((int)c)++; // this unbox value and return value as literal on stack , so we can't  make 5 = 6 
        // this is right value so we can read from it not write to it 

        int j = (int)c;
        j++; 

        

    }

    // boxing and unboxing has cost especially in memory managment 
}