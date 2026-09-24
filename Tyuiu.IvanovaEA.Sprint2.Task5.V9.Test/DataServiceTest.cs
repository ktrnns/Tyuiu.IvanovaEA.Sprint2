using Tyuiu.IvanovaEA.Sprint2.Task5.V9.Lib;

namespace Tyuiu.IvanovaEA.Sprint2.Task5.V9.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidFindDateOfNextDay()
        {
            DataService ds = new DataService();

            // 28 февраля - 1 марта
            Assert.AreEqual("01.03", ds.FindDateOfNextDay(2, 28));

            // 31 января - 1 февраля
            Assert.AreEqual("01.02", ds.FindDateOfNextDay(1, 31));

            // 30 апреля - 1 мая
            Assert.AreEqual("01.05", ds.FindDateOfNextDay(4, 30));

            // 30 декабря - 31 декабря
            Assert.AreEqual("31.12", ds.FindDateOfNextDay(12, 30));
        }
    }
}
