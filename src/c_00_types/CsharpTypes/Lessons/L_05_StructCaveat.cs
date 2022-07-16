namespace CsharpTypes.Lessons;

internal static class L_05_StructCaveat
{
    public class Person : Object
    { }


    // by initializing struct , all its member get default value , so there won't be any error 
    struct PersonStruct 
    {
        // in struct , when you should define a constructor , you should assign all members 
    }

    public static void Run()
    {
        int i = 5;
        
        // System.Int32
        Console.WriteLine(i.GetType());
        
        // System.ValueType
        Console.WriteLine(i.GetType().BaseType);
        
        // System.Object 
        Console.WriteLine(i.GetType().BaseType.BaseType);

        // null
        Console.WriteLine(i.GetType().BaseType.BaseType.BaseType);

        // error : null doesn't have base types 
        string msg = i.GetType()?.BaseType?.BaseType?.BaseType?.BaseType?.ToString() ?? "this is null";
        Console.WriteLine(msg);

        //=============
        var person = new Person();
        // Person
        Console.WriteLine(person.GetType());

        // System.Object 
        Console.WriteLine(person.GetType().BaseType);

        //=============
        var personStruct = new PersonStruct();

        // Person
        Console.WriteLine(personStruct.GetType());

        // System.Object 
        Console.WriteLine(personStruct.GetType().BaseType);

    }
}