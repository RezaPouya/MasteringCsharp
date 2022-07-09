using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CovarianceAndContravariance;

internal static class ArrayExample
{
    public static void CovarainceTest()
    {
        Orange[] orangeArray = { new Orange() };

        // Here the covariance relationship implies that an array of Orange is an array of Fruit.
        Fruit[] fruitArray = orangeArray;  // But this is not safe!!

        fruitArray[0] = new Orange();  // BOUM! ArrayTypeMistmatchException thrown by the runtime!!
    }


    public static void CovarainceTest_TypeSafe()
    {
        Orange[] array1 = { new Orange() };

        IEnumerable<Fruit> fruitSeq = array1;   // This is safe!!

        // Invalid assignment, IEnumerable is read-only in the sense that its elements cannot be overridden
        //fruitSeq[0] = new Orange();
    }


    public static void Contravariance()
    {
        Fruit[] fruits = { new Orange() };

        //ERROR: Cannot implicitly convert type 'CovarianceAndContravariance.Fruit[]'
        //to 'CovarianceAndContravariance.Orange[]'. An explicit conversion exists
        //(are you missing a cast?)	
        //Orange[] oranges = fruits;


        Orange[] oranges = (Orange[])fruits;
    }
}
