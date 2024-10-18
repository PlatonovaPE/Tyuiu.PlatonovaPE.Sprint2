using System.ComponentModel;
using System.ComponentModel.Design;
using Tyuiu.PlatonovaPE.Sprint2.Task7.V14.Lib;


Console.WriteLine("********************************************************************************");
Console.WriteLine("* Исходные данные                                                              *");
Console.WriteLine("********************************************************************************");

Console.WriteLine("Введите  значение Х:");
double x = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите значение У:");
double y = Convert.ToDouble(Console.ReadLine());

DataService ds = new DataService();
bool res = ds.CheckDotInShadedArea(x, y);


Console.WriteLine("********************************************************************************");
Console.WriteLine("* Результат:                                                                   *");
Console.WriteLine("********************************************************************************");


if (res)
{
    Console.WriteLine("Точно находится в заштрихованной области");
}
else
{
    Console.WriteLine("Точно не находится в заштрихованной области");
}


Console.ReadKey();
