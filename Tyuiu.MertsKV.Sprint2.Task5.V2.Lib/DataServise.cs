﻿using tyuiu.cources.programming.interfaces;
using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.MertsKV.Sprint2.Task5.V2.Lib
{
    public class DataServise : ISprint2Task5V2
    {
      
        
            public string FindMonthSeason(int value)
        {
            string res = value switch
            {
                12 or 1 or 2 => "Зима",
                3 or 4 or 5 => "Весна",
                6 or 7 or 8 => "Лето",
                9 or 10 or 11 => "осень",
                _ => "Ошибка: нет такого месяца"
            };

            return res;
        }
    }
}
