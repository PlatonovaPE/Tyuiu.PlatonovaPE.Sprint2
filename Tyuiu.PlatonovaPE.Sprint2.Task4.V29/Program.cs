using System.ComponentModel;
using Tyuiu.PlatonovaPE.Sprint2.Task4.V29.Lib;
namespace Tyuiu.PlatonovaPE.Sprint2.Task2.V28
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();


            Console.WriteLine("********************************************************************************");
            Console.WriteLine("* Исходные данные                                                              *");
            Console.WriteLine("********************************************************************************");

            Console.WriteLine("Введите значение Х:");
            double x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите значение Y:");
            double y = Convert.ToInt32(Console.ReadLine());

            double res = ds.Calculate(x, y);



            Console.WriteLine("********************************************************************************");
            Console.WriteLine("* Результат:                                                                   *");
            Console.WriteLine("********************************************************************************");

            Console.WriteLine(" Значение функции = " + res);


            Console.ReadKey();

        }
    }
}
