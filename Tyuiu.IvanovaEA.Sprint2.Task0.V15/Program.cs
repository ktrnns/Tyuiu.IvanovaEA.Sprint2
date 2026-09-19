using Tyuiu.IvanovaEA.Sprint2.Task0.V15.Lib;

//    Написать программу из операций сравнений (==, !=, <, >, <=, >=, последовательность операций не должна нарушаться) 
//    и арифметических выражений, которая вернет логическую последовательность(массив): 
//    (False, False, True, True, False, False), при x = 3105, y = 275

namespace Tyuiu.IvanovaEA.Sprint2.Task0.V15
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService(); 

            int x = 3105;
            int y = 275;
            bool[] res = new bool[6];
            res = ds.GetCompareOperations(x, y);

            Console.Title = "Спринт #2 | Выполнила: Иванова Е. А. | ПИНб-26-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема: Операции сравнения                                                *");
            Console.WriteLine("* Задание #0                                                              *");
            Console.WriteLine("* Вариант #15                                                             *");
            Console.WriteLine("* Выполнила: Иванова Екатерина Александровна | ПИНб-26-1                  *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу из операций сравнений (==, !=, <, >, <=, >=,         *");
            Console.WriteLine("* последовательность операций не должна нарушаться) и арифметических      *");
            Console.WriteLine("* выражений, которая вернет логическую последовательность(массив):        *");
            Console.WriteLine("* (False, False, True, True, False, False), при x = 3105, y = 275.        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("* X = " + x);
            Console.WriteLine("* Y = " + y);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine(res[i]);
            }

            Console.ReadKey();
        }
    }
}