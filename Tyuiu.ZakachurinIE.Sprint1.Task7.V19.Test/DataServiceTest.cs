using Tyuiu.ZakachurinIE.Sprint1.Task7.V19.Lib;

namespace Tyuiu.ZakachurinIE.Sprint1.Task7.V19.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 2.0;
            var res = ds.Calculate(x);
            Assert.AreEqual(15.409, res);
        }
    }
}
