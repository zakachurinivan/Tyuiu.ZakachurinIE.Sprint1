using Tyuiu.ZakachurinIE.Sprint1.Task5.V4.Lib;

namespace Tyuiu.ZakachurinIE.Sprint1.Task5.V4.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            int x = 7100;
            var res = ds.SecondsToHours(x);
            Assert.AreEqual(1, res);
        }
    }
}
