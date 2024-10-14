using Tyuiu.PlatonovaPE.Sprint2.Task1.V18.Lib;
namespace Tyuiu.PlatonovaPE.Sprint2.Task1.V18
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            int a = 155;
            int b = 696;
            int c = 242;
            int d = 541;


            bool[] res = new bool[6];
            res = ds.GetLogicOperations(a, b, c, d);


            Console.WriteLine("********************************************************************************");
            Console.WriteLine("* Исходные данные                                                              *");
            Console.WriteLine("********************************************************************************");


            Console.WriteLine("a = " + a);

            Console.WriteLine("b = " + b);

            Console.WriteLine("c = " + c);

            Console.WriteLine("d = " + d);





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
