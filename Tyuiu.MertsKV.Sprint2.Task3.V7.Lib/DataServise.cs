using tyuiu.cources.programming.interfaces;
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.MertsKV.Sprint2.Task3.V7.Lib
{
    public class DataServise : ISprint2Task3V7
    {
        public double Calculate(double x)
        {
            double y = 0;

            if (x > 1)
            {
                y = Math.Round(x * Math.Pow((Math.Pow(x, 2) + 1) / (x - 1), x), 3);
            }
            else
            {
                if (x == 0)
                {
                    y = Math.Round((Math.Pow(x, 2) - Math.Cos(Math.Pow(x, 2)) + 10) / (Math.Pow(x, 2) - Math.Sin(Math.Pow(x, 2)) + 12), 3);
                }
                else
                {
                    if (-11 < x && x < 2)
                    {
                        y = Math.Round(Math.Pow(7 + (1) / (Math.Pow(x, 2)), 2), 3);
                    }
                    else
                    {
                        if (x < -11)
                        {
                            y = Math.Round(Math.Pow(x, 4) - (3) / (x), 3);
                        }
                    }
                }
            }
            return y;
        }
    }
}
