namespace CsharpTypes.Lessons;

internal static class L_15_ObjecTypePointer
{
    protected class Cow
    {
        public int mooCount;
    }

    public static void Run()
    {
        var betsy = new Cow();
        betsy.mooCount = 9;
        var groogy = new Cow();
        groogy.mooCount = 3;

        //Type betsyType = betsy.GetType();

        lock (betsy)
        {
            Console.WriteLine("betsy");
        }
    }

    /// every object in heap has three parts:
    ///     1- ojbect content 
    ///     2- Type Object Pointer  -- pointer of to instance of type obejct which has info of current type ( reflection is using them)
    ///     3- Sync Block Index 
    ///     

    /// Type obejects are stored in Heap - every type instance has an object(type_
    /// 
    /// Sync block index - 4 bytes 
    /// 99% time we don't use it ( its for locking on object )  -- wasting 4 byte for every object !!!!!!!!!
    /// 

    /// C# value types are sealed and compile time = run time ; and don't SBI 
}

