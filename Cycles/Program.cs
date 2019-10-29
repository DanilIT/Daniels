using System;
using System.Collections.Generic;

namespace Cycles
{
    class Program
    {
        static void Main(string[] args)
        {

            /*  for (int i = 1; i <= 29; i++) {

                  if (i == 27)
                  {
                      continue;
                  }

                  Console.WriteLine(i);

              }
              */

            //int x = 1;
            //while (x <= 29)
            //{
            //    if (x == 27)
            //    {
            //        x++;
            //        continue;
            //    }
            //    Console.WriteLine(x);
            //    x++;

            //}


            //   Console.WriteLine(x);

            //int[,] numbers = new int[2, 3] { { 0, 34, -2 }, { 3, -4, 5 } };
            //int min_num = numbers[0, 0];
            //for (byte i = 0; i < 2; i++)
            //{
            //    for (byte j = 0; j < 3; j++)
            //    {
            //        if (numbers[i, j] < min_num)
            //        {
            //            min_num = numbers[i, j];
            //        }
            //    }
            //}
            //Console.Write("Minimum number: " + min_num);


            List<int> digits = new List<int> ();
            digits.Add(32);
            digits.Add(123);
            digits.Add(34);
            digits.Add(45);
            digits.Add(876);
            digits.Add(45);
            digits.Add(46);
            digits.Add(7856);

            int max_num = digits[0];
            for (byte i = 0; i < digits.Count; i++)
                if (digits[i] > max_num)
                {
                    max_num = digits[i];
                }

            Console.WriteLine("maximum nnumber: " + max_num);



            Console.ReadLine();
        

        }
    }
}
