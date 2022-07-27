namespace CsharpTypes.Lessons;

internal static class L_09_Nullable_Miscellaneous_Feature
{
    public static void Run()
    {
        int? i = null;
        int j = i ?? 8; // null coalescing

        // what compiler do
        int k = i.HasValue ? i.GetValueOrDefault() : 8;
        int k2 = i.GetValueOrDefault(8);

        //------------

        int gg = 5;
        int? ff = gg;
        int rr = (int)ff; // should use explicit conversion
    }
}