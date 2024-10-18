using System.ComponentModel;
using System.ComponentModel.Design;
using Tyuiu.PlatonovaPE.Sprint2.Task5.V2.Lib;
DataService ds = new DataService();


Console.WriteLine("********************************************************************************");
Console.WriteLine("* Исходные данные                                                              *");
Console.WriteLine("********************************************************************************");

Console.WriteLine("Введите месяц:");
int MonthSeason = Convert.ToInt32(Console.ReadLine());

string res;

if ((MonthSeason < 1) || (MonthSeason > 12))
{
    res = "ВВедено неверное значение";
}
else
{
    res = "Это сезон: " + ds.FindMonthSeason(MonthSeason);

}


Console.WriteLine("********************************************************************************");
Console.WriteLine("* Результат:                                                                   *");
Console.WriteLine("********************************************************************************");

Console.WriteLine(res);


Console.ReadKey();
