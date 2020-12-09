using System;
using System.Linq; //Linq makes the Methods accessible working on collections, it give mopre functionalities to Objects!

namespace _07.SkipOnColections
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[] {1,2,3,4,5,6,7 };
            Console.WriteLine(string.Join(" ", numbers.Skip(2).Take(5).Skip(1)));
            // Skip ->  omit the 1 and 2 element from the array and take only the next two -> 3 and  4 elemetns;
            // so we skpt the first two elements , then we take the next two elements, then we skip the  next 2;
            // Skip says how many elements to be bypassed, Skip(1) -means bypass 1 element, skip(2) bypass element 1 and element 2;
        }
    }
}
