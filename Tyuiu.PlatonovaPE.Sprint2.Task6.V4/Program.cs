using System.ComponentModel;
using System.ComponentModel.Design;
using Tyuiu.PlatonovaPE.Sprint2.Task6.V4.Lib;

DataService ds = new DataService();
Console.Title = "Спринт #2 | Выполнила: Платонова Полина Евгеньвна  | ИСПб-24-1";
Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #2                                                               *");
Console.WriteLine("* Тема: Добавление к решению итоговых проектов по спринту                 *");
Console.WriteLine("* Задание #7                                                              *");
Console.WriteLine("* Вариант #14                                                             *");
Console.WriteLine("* Выполнила:  Платонова Полина Евгеньвна  | ИСПб-24-1                        *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                *");
Console.WriteLine("* Написать программy, которая запрашивает исходные данные и вычисляет,    *");
Console.WriteLine("* находится ли точка с координатами X,Y в заштрихованной области.         *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");
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
