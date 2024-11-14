using System.ComponentModel;
using System.ComponentModel.Design;
using Tyuiu.PlatonovaPE.Sprint2.Task5.V2.Lib;
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
