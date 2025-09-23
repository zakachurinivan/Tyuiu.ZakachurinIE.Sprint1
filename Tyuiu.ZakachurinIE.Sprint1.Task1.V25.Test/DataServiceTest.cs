﻿using Tyuiu.ZakachurinIE.Sprint1.Task1.V25.Lib;
namespace Tyuiu.ZakachurinIE.Sprint1.Task1.V25.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 1.0;
            double y = 2.0;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(1,res);
        }
    }
}
