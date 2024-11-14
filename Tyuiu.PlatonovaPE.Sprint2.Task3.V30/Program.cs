using Tyuiu.PlatonovaPE.Sprint2.Task3.V30.Lib;
namespace Tyuiu.PlatonovaPE.Sprint2.Task2.V28
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();


            DataService ds = new DataService();
            Console.Title = "Спринт #2 | Выполнила: Платонова Полина Евгеньвна  | ИСПб-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема: Добавление к решению итоговых проектов по спринту                 *");
            Console.WriteLine("* Задание #5                                                              *");
            Console.WriteLine("* Вариант #2                                                             *");
            Console.WriteLine("* Выполнила:  Платонова Полина Евгеньвна  | ИСПб-24-1                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("*  По данному месяцу, определите в какую пору года попадает этот месяц .    *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
    

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
