using tyuiu.cources.programming.interfaces;
using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.MertsKV.Sprint2.Task7.V10.Lib
{
    public class DataServise : ISprint2Task7V10
    {
        public bool CheckDotInShadedArea(double x, double y)
        {
            bool res;
            if ((y >= x * x - 2) && (y >= 0 && y <= x) && (y <= 0 && y >= -x))
            {
                res = true;
            }
            else
            {
                res = false;
            }
                return res;
        }
    }
}
