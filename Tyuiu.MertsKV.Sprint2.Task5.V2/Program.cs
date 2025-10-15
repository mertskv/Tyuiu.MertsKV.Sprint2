using Tyuiu.MertsKV.Sprint2.Task5.V2.Lib;
namespace Tyuiu.MertsKV.Sprint2.Task5.V2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataServise ds = new DataServise();

            Console.Write("Введите номер месяца (1–12): ");
            int month = Convert.ToInt32(Console.ReadLine());

            
            string season = ds.FindMonthSeason(month);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Пора года: " + season);
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Нажмите любую клавишу для выхода...");
            Console.ReadKey();
        }
    }
}
