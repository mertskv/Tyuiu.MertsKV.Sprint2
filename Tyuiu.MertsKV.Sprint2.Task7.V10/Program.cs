﻿using Tyuiu.MertsKV.Sprint2.Task7.V10.Lib;
namespace Tyuiu.MertsKV.Sprint2.Task7.V10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataServise ds = new DataServise();

            
            Console.WriteLine("*****************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                          *");
            Console.WriteLine("*****************************************************************************");

            Console.Write("Введите значение переменной X  ");
            double x = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите значение переменной Y  ");
            double y = Convert.ToDouble(Console.ReadLine());

            bool res = ds.CheckDotInShadedArea(x, y);

            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                             *");
            Console.WriteLine("**************************************************************************");

            if (res)
            {
                Console.WriteLine("Точка находиться в заштрихованной области");
            }

            else
            {
                Console.WriteLine("Точка не находится в заштрихованной области");
            }

            Console.ReadKey();
        }
    }
}
