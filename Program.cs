using System;
using System.Linq;

namespace live_coding3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int [] array_one = { 1, 5, 2 };
            int [] array_two = { 3, 6, 4 };
            int [] zipped_array = new int[array_one.Length+array_two.Length];
            int a = 0;
            for (int k=0; k<zipped_array.Length; k++)
            {
                zipped_array[a]= array_one[k];
                a++;
                zipped_array[a] = array_two[k];
                a++;

            }
            for (int k = 0; k < zipped_array.Length; k++)
            {
                Console.WriteLine(zipped_array[k]);
            }



            
        }

        
    }
}
