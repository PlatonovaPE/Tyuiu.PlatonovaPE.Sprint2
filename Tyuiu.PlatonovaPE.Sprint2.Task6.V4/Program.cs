using System.ComponentModel;
using System.ComponentModel.Design;
using Tyuiu.PlatonovaPE.Sprint2.Task6.V4.Lib;
DataService ds = new DataService();


Console.WriteLine("********************************************************************************");
Console.WriteLine("* Исходные данные                                                              *");
Console.WriteLine("********************************************************************************");

Console.WriteLine("Введите число:");
int suilt = Convert.ToInt32(Console.ReadLine());

string res;

if ((suilt < 1) || (suilt > 4))
{
    res = "ВВедено неверное значение";
}
else
{
    res = "Это масть: " + ds.FindCardSuit(suilt);

}


Console.WriteLine("********************************************************************************");
Console.WriteLine("* Результат:                                                                   *");
Console.WriteLine("********************************************************************************");

Console.WriteLine(res);


Console.ReadKey();
