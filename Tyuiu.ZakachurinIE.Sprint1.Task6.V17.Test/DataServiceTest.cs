using Tyuiu.ZakachurinIE.Sprint1.Task6.V17.Lib;

namespace Tyuiu.ZakachurinIE.Sprint1.Task6.V17.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidString()
        {
            string test = "боб";
            DataService ds = new DataService();
            var res = ds.CheckPalindrome(test);

            Assert.IsTrue(res);
        }
    }
}
