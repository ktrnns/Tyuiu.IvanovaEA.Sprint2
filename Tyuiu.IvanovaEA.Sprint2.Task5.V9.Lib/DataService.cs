using tyuiu.cources.programming.interfaces.Sprint2;

//  Условие: Дата некоторого дня характеризуется двумя натуральными числами: m(порядковый номер месяца) и n(число). 
//    По заданным n и m определить дату следующего дня (принять, что n и m не характеризуют 31 декабря).

namespace Tyuiu.IvanovaEA.Sprint2.Task5.V9.Lib
{
    public class DataService : ISprint2Task5V9
    {
        public string FindDateOfNextDay(int m, int n)
        {
            if (m < 1 || m > 12)
                return "Месяц должен быть от 1 до 12!";

            if (n < 1 || n > 31)
                return "Число должно быть от 1 до 31!";

            int daysInMonth;

            switch (m)
            {
                case 1:  // январь
                case 3:  // март
                case 5:  // май
                case 7:  // июль
                case 8:  // август
                case 10: // октябрь
                case 12: // декабрь
                    daysInMonth = 31;
                    break;

                case 4:  // апрель
                case 6:  // июнь
                case 9:  // сентябрь
                case 11: // ноябрь
                    daysInMonth = 30;
                    break;

                case 2:  // яевраль
                    daysInMonth = 28;
                    break;

                default:
                    daysInMonth = 0;
                     break;
            }

            int nextM;
            int nextN;

            if (n < daysInMonth)
            {
                nextM = m;
                nextN = n + 1;
            }
            else
            {
                nextM = m + 1;
                nextN = 1;
            }

            return ($"{nextN:D2}.{nextM:D2}");
        }
    }
}
    