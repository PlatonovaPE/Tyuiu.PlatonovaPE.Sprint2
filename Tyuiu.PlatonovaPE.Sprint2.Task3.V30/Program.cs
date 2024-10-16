using Tyuiu.PlatonovaPE.Sprint2.Task3.V30.Lib;
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
            int x = Convert.ToInt32(Console.ReadLine());
            double res = ds.Calculate(x);



            Console.WriteLine("********************************************************************************");
            Console.WriteLine("* Результат:                                                                   *");
            Console.WriteLine("********************************************************************************");

            Console.WriteLine(" Значение функции = " + res);
            

            Console.ReadKey();

        }
    }
}
