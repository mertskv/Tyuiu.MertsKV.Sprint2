﻿using Tyuiu.MertsKV.Sprint2.Task1.V17.Lib;

namespace Tyuiu.MertsKV.Sprint2.Task1.V17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataServise ds = new DataServise();

            int a = 135;
            int b = 123;
            int c = 455;
            int d = 321;


            bool[] res = new bool[6];
            res = ds.GetLogicOperations(a, b, c, d);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("a = " + a);
            Console.WriteLine("b = " + b);
            Console.WriteLine("c = " + c);
            Console.WriteLine("d = " + d);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine(res[i]);
            }
        }
    }
}
