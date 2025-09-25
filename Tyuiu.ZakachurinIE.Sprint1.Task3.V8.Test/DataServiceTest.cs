using Tyuiu.ZakachurinIE.Sprint1.Task3.V8.Lib;

namespace Tyuiu.ZakachurinIE.Sprint1.Task3.V8.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 2500;
            double y = 20;
            double z = 30;
            var res = ds.IncomeAmount(x, y, z);
            Assert.AreEqual(41.10, res);
        }
    }
}
