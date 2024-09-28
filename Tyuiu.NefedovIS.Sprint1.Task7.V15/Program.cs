using Tyuiu.NefedovIS.Sprint1.Task7.V15.Lib;

namespace Tyuiu.NefedovIS.Sprint1.Task7.V15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            double x;

            Console.WriteLine("Введите x:");
            x = Convert.ToDouble(Console.ReadLine());


            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine($"{ds.Calculate(x)}");

            Console.ReadLine();
        }
    }
}