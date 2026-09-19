using tyuiu.cources.programming.interfaces.Sprint2;

//    Написать программу из операций сравнений (==, !=, <, >, <=, >=, последовательность операций не должна нарушаться) 
//    и арифметических выражений, которая вернет логическую последовательность(массив): 
//    (False, False, True, True, False, False), при x = 3105, y = 275 

namespace Tyuiu.IvanovaEA.Sprint2.Task0.V15.Lib
{
    public class DataService : ISprint2Task0V15
    {
        public bool[] GetCompareOperations(int x, int y)
        {
            bool[] res = new bool[6];

            res[0] = x == y;
            res[1] = x != y + 2830;
            res[2] = x < y + 2831;
            res[3] = x > y;
            res[4] = x <= y;
            res[5] = x >= y + 2831;

            return res;
        }
    }
}
