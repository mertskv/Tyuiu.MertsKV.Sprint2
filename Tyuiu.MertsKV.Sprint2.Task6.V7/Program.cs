using Tyuiu.MertsKV.Sprint2.Task6.V7.Lib;
namespace Tyuiu.MertsKV.Sprint2.Task6.V7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataServise ds = new DataServise();
            
            Console.WriteLine("Введите год:");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите сколько месяцев прошло:");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Результат: " + ds.FindMonthName(a, b));
            Console.ReadKey();
        }
    }
}
