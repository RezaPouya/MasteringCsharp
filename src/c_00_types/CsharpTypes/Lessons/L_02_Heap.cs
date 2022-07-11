namespace CsharpTypes.Lessons;

internal static class L_02_Heap
{
    public class Person
    {
        // all members of reference types are placed in heap
        public string Name;
        public int Age; 

        public Person(string name, int age )
        {
            Name = name;
        }
    }

    public static void Run()
    {
        int jhoneAge = 20;
        Person Jhone = new Person("Jhone" , jhoneAge);
        Person Tom = new Person("Tom" , 23);
        Person JhoneClone = Jhone;
    }

    // new in reference type will go to heap, allocate a memory to object and return its address reference
}