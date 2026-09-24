using tyuiu.cources.programming.interfaces.Sprint2;

//Написать программу на C#, которая запрашивает исходные данные (вещественные значения) и вычисляет, 
//    находится ли точка с координатами X,Y в заштрихованной области.
//    y = sin(x), y = 0.5 

namespace Tyuiu.IvanovaEA.Sprint2.Task7.V9.Lib
{
    public class DataService : ISprint2Task7V9
    {
        public bool CheckDotInShadedArea(double x, double y)
        {
            bool res;

            if (y >= 0.5 && y <= Math.Sin(x))
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
