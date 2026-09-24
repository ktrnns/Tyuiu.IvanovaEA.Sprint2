using tyuiu.cources.programming.interfaces.Sprint2;

//  Условие: Дата некоторого дня характеризуется двумя натуральными числами: m(порядковый номер месяца) и n(число). 
//    По заданным n и m определить дату следующего дня (принять, что n и m не характеризуют 31 декабря).

namespace Tyuiu.IvanovaEA.Sprint2.Task6.V9.Lib
{
    public class DataService : ISprint2Task6V9
    {
        public string FindDateOfNextDay(int m, int n)
        {
            switch (m)
            {
                // Месяцы с 31 днём
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                    return n < 31 ? $"{n + 1:D2}.{m:D2}" : $"01.{m + 1:D2}";
    

                case 12:
                    // 31 декабря
                    return $"{n + 1:D2}.12";

                // Месяцы с 30 днями
                case 4:
                case 6:
                case 9:
                case 11:
                    return n < 30 ? $"{n + 1:D2}.{m:D2}" : $"01.{m + 1:D2}";

                // Февраль
                case 2:
                    return n < 28 ? $"{n + 1:D2}.02" : "01.03";

                default:
                    return "Месяц должен быть от 1 до 12!";
            }
        }
    }
}
