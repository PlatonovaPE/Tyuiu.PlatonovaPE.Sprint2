using System.ComponentModel.Design;
using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.PlatonovaPE.Sprint2.Task2.V28.Lib
{
    public class DataService : ISprint2Task2V28
    {
        public bool CheckDotInShadedArea(int x, int y)
        {
            bool res;

            if ((x >= 3) && (x <= 5) && (x >= 10) && (x <= 13) && (x >= 10) && (x <= 12) && (x >= 6) && (x <= 9) && (x >= 3) && (x <= 8) && (x >= 6) && (x <= 8) && (x >= 3) && (x <= 13) && (x >= 7) && (x <=10) && (y >= 4) && (y <= 5) && ( y >= 3) && (y <= 7) && (y >= 2) && (y <= 3) && ( y >= 4) && (y <= 5) && (y >= 6) && (y <= 7) && (y >= 8) && ( y <= 10) && ( y >= 9) && (y <= 13))
            {
                res = true;
            }
            else
            {
                res = false;
            }
            return res;
        }
    }
}
