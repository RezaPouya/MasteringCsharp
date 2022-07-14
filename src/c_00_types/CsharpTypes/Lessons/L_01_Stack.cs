using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpTypes.Lessons;

internal static class L_01_Stack
{
    public static void Run()
    {
        int i = 1;
        int j = 2;
        AnotherMethod();
        int k = 3;
        AnotherMethod();
    }


    private static void AnotherMethod()
    {
        int x = 1;
        int y = 2;
    } // when the execution arrived at here, it will remove x,y 
}
