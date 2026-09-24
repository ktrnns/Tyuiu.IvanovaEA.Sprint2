using Tyuiu.IvanovaEA.Sprint2.Task6.V9.Lib;

//  Условие: Дата некоторого дня характеризуется двумя натуральными числами: m(порядковый номер месяца) и n(число). 
//    По заданным n и m определить дату следующего дня (принять, что n и m не характеризуют 31 декабря).

namespace Tyuiu.IvanovaEA.Sprint2.Task6.V9
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #2 | Выполнила: Иванова Е. А. | ПИНб-26-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема: Получение результата из switch                                    *");
            Console.WriteLine("* Задание #6                                                              *");
            Console.WriteLine("* Вариант #9                                                              *");
            Console.WriteLine("* Выполнила: Иванова Екатерина Александровна | ПИНб-26-1                  *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дата некоторого дня характеризуется двумя натуральными числами:         *");
            Console.WriteLine("* m(порядковый номер месяца) и n(число). По заданным n и m определит      *");
            Console.WriteLine("* дату следующего дня (принять, что n и m не характеризуют 31 декабря).   *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.Write("Введите номер месяца (1-12): ");
            int m = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите число: ");
            int n = Convert.ToInt32(Console.ReadLine());

            string res = ds.FindDateOfNextDay(m, n);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine($"Дата следующего дня: {res}");

            Console.ReadKey();
        }
    }
}