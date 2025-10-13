using Tyuiu.MertsKV.Sprint2.Task0.V19.Lib;
namespace Tyuiu.MertsKV.Sprint2.Task0.V19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataServise ds = new DataServise();

            int x = 105;
            int y = 177;
            bool[] res = new bool[6];
            res = ds.GetCompareOperations(x, y);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("X = " + x);
            Console.WriteLine("Y = " + y);

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
