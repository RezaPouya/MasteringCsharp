namespace CsharpTypes.Lessons;


internal static class L_07_BoxingVsConsuming
{
    public static void Run()
    {
        object o = 5;
        // ((int)o); // erorr
        ((int)o).ToString();
        int i = ((int)o);

        // ------------------

        object o2 = 5;
        Type type  = o2.GetType();
        Console.WriteLine(type.Name);
        Console.WriteLine(type.Namespace);

        //----------------
        5.ToString();   // this doesn't new boxing 
        5.GetType();    // this need boxing because with need type object pointer to get reference to 'type info'

        //----------------
        // we should unbox to excact same type value 
        object o3 = 5;
        long l = ((long)o3); // run time exception: 'Unable to cast object of type 'System.Int32' to type 'System.Int64'.'

    }

    // object instance on heap have 2 further data member 
    // - Synch block index    : this is used for threading 
    // - Type object pointer  : say the type of object inside the box 
}