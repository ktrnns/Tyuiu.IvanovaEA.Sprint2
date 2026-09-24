using Tyuiu.IvanovaEA.Sprint2.Task4.V21.Lib;

namespace Tyuiu.IvanovaEA.Sprint2.Task4.V21.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCondition1()
        {
            DataService ds = new DataService();

            double x = 1;
            double y = 5;

            double res = ds.Calculate(x, y);

            double wait = 1024;

            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void ValidCondition2()
        {
            DataService ds = new DataService();

            double x = 5;
            double y = 1;

            double res = ds.Calculate(x, y);

            double wait = 2.665;

            Assert.AreEqual(wait, res);
        }
    }
}
