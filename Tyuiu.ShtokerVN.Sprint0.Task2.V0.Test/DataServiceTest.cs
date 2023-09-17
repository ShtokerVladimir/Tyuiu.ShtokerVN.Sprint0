using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.ShtokerVN.Sprint0.Task2.V0.Lib;

namespace Tyuiu.ShtokerVN.Sprint0.Task2.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckGetMessageValid()
        {
            var name = "Вова";
            var res = DataService.GetMessage(name);



            Assert.AreEqual("Привет..., Вова", res);
        }
    }
}
