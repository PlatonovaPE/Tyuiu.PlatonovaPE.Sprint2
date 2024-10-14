using Tyuiu.PlatonovaPE.Sprint2.Task0.V27.Lib;
namespace Tyuiu.PlatonovaPE.Sprint2.Task0.V27
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            int x = 1305;
            int y = 275;

            bool[] res = new bool[6];
            res = ds.GetCompareOperations(x, y);


            Console.WriteLine("********************************************************************************");
            Console.WriteLine("* Исходные данные                                                              *");
            Console.WriteLine("********************************************************************************");


            Console.WriteLine("Х = " + x);

            Console.WriteLine("У = " + y);





            Console.WriteLine("********************************************************************************");
            Console.WriteLine("* Результат:                                                                   *");
            Console.WriteLine("********************************************************************************");

            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine(res[i]);
            }


            Console.ReadKey();

        }
    }
}
