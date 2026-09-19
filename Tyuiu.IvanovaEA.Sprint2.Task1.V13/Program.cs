using Tyuiu.IvanovaEA.Sprint2.Task1.V13.Lib;

//Написать программу из операций сравнений (==, !=, <, >, <=, >=, последовательность можно чередовать, 
//    но использовать один раз в выражении) и логических операций (|, &, ||, &&, !, ^, 
//    последовательность операций не должна нарушаться), а также арифметических выражений, 
//    которая вернет логическую последовательность(массив): (True, True, True, True, True, False), 
//    при a = 145, b = 916, c = 164, d = 137

namespace Tyuiu.IvanovaEA.Sprint2.Task1.V13
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            int a = 145;
            int b = 916;
            int c = 164;
            int d = 137;

            bool[] res = new bool[6];
            res = ds.GetLogicOperations(a, b, c, d);

            Console.Title = "Спринт #2 | Выполнила: Иванова Е. А. | ПИНб-26-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема: Логические операции                                               *");
            Console.WriteLine("* Задание #1                                                              *");
            Console.WriteLine("* Вариант #13                                                             *");
            Console.WriteLine("* Выполнила: Иванова Екатерина Александровна | ПИНб-26-1                  *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу из операций сравнений (==, !=, <, >, <=, >=,         *");
            Console.WriteLine("* последовательность можно чередовать, но использовать один раз в         *");
            Console.WriteLine("* выражении) и логических операций (|, &, ||, &&, !, ^,                   *");
            Console.WriteLine("* последовательность операций не должна нарушаться), а также              *");
            Console.WriteLine("* арифметических выражений, которая вернет логическую последовательность  *");
            Console.WriteLine("* (массив): (True, True, True, True, True, False)                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("* A = " + a);
            Console.WriteLine("* B = " + b);
            Console.WriteLine("* C = " + c);
            Console.WriteLine("* D = " + d);

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