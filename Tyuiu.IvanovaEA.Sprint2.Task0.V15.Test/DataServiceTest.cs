using Tyuiu.IvanovaEA.Sprint2.Task0.V15.Lib;

namespace Tyuiu.IvanovaEA.Sprint2.Task0.V15.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidGetCompareOperations()
        {
            DataService ds = new DataService();

            int x = 3105;
            int y = 275;

            bool[] res = ds.GetCompareOperations(x, y);

            bool[] wait = new bool[6] { false, false, true, true, false, false };

            CollectionAssert.AreEqual(wait, res);
        }
    }
}
