using System;

namespace datamassivesTask
{
    class Program
    {
        static void Main(string[] args)
     

                    

        {
            int [] arr_1 = { 17, 32, 7, 12, 33 };
            int [] arr_2 = { 11, 22, 33, 44, 55 };


            int[] temp = new int[arr_1.Length];

            Console.WriteLine($"1 - {arr_1[0]}, 2 - {arr_2[0]}");

            arr_1.CopyTo(temp, 0);
            Array.Clear(arr_1, 0, arr_1.Length);

            arr_2.CopyTo(arr_1, 0);
            Array.Clear(arr_2, 0, arr_2.Length);

            temp.CopyTo(arr_2, 0);

            Array.Clear(temp, 0, temp.Length);



            Console.WriteLine($"1 - {arr_1[0]}, 2 - {arr_2[0]}");
            Console.WriteLine ("Hi");
            Console.ReadLine();
        }
    }
}
