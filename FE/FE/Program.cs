using System;

namespace FE
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array1 = new int[] { 1, 2, 3, };
            int[] array2 = new int[] { 6, 7, 8, };
            foreach(int i in Mix(array1, array2))
            {
                Console.WriteLine(i);
            }
            Console.ReadLine(); 
        }

        static int[] Mix(int[] array1, int[] array2)
        {
            int arrayLength = 2 * array1.Length;
            int[] mixedArray = new int[arrayLength];
            int k = 0;
            for (int i = 0; i < array1.Length; i++)
            {
                mixedArray[k++] = array1[i];
                mixedArray[k++] = array2[i];
            }            
            return mixedArray;
        }
    }
}
