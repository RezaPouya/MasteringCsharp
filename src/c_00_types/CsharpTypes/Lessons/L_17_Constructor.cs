using System.Runtime.InteropServices;

namespace CsharpTypes.Lessons;

internal static class L_17_Constructor
{
    protected class Farm
    {
        public Farm()
        {
            Console.WriteLine($"Farm()");
        }

        Cow cow1 = new Cow("Betsy");
        Cow cow2 = new Cow("Georgy");
    }

    protected class Farm_HowItWillReallywork
    {
        public Farm_HowItWillReallywork()
        {
            cow1 = new Cow("Betsy");
            cow2 = new Cow("Georgy");
            Console.WriteLine($"Farm()");
        }

        Cow cow1;
        Cow cow2; 
    }

    protected class RezaFarm : Farm
    {
        Cow cow3 = new Cow("Reza's Cow");
        public RezaFarm() : base () 
        {
            Console.WriteLine($"Reza's Farm()");
        }
    }

    protected class Cow
    {
        public Cow(string name)
        {
            Console.WriteLine($"Cow({name})");
        }
    }

    public static void Run()
    {
        //Farm farm = new Farm();
        RezaFarm rezaFarm = new RezaFarm();
    }


    // which one will print first  ??
    // Answer : 
    // Betsy
    // Georgy
    // Farm() 

    // actually above code is syntactic sugger ... compiler really do ( constructor )
    //      -- all field which should initialize ( embeded constructor calls ) 
    //      -- what we really write 


    // which one will print first (Reza Farm)  ??
    // Answer : 
    // Reza's Cow 
    // Betsy
    // Georgy
    // Farm() 
    // Reza's Farm 

    // why this is like this ? C# think , maybe there is virutal method in constructor which need fields ... 
}

