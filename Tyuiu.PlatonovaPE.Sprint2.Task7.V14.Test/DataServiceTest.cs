using Tyuiu.PlatonovaPE.Sprint2.Task7.V14.Lib;
namespace Tyuiu.PlatonovaPE.Sprint2.Task7.V14.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCheckDotInShadedArea1()
        {
            DataService ds = new DataService();
            double x = 0.7;
            double y = 0.7;

            bool res = ds.CheckDotInShadedArea(x, y);
            bool wait = true;
            Assert.AreEqual(true, res);

        }
    }
}