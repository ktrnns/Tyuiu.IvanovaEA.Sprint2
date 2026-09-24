using tyuiu.cources.programming.interfaces.Sprint2;

//    Написать программу, которая вычисляет требуемое значение с использованием тернарного оператора, 
//    где пользователь вводит значение переменных x, y с клавиатуры, 
//    если x < y - 2, то z = (2 + (x+1)/x^2)^y 
//    иначе (x^2+10)/(y^2 - sin(x^2) + 12)

namespace Tyuiu.IvanovaEA.Sprint2.Task4.V21.Lib
{
    public class DataService : ISprint2Task4V21
    {
        public double Calculate(double x, double y)
        {
            double z = x < y -2 ? Math.Pow(2 + (x + 1) / Math.Pow(x, 2), y) : 
                                  (Math.Pow(x, 2) + 10) / (Math.Pow(y, 2) - Math.Sin(Math.Pow(x, 2)) + 12);

            return Math.Round(z, 3);
        }
    }
}
