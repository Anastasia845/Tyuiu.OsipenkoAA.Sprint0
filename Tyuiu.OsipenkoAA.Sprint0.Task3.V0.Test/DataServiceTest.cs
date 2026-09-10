using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.OsipenkoAA.Sprint0.Task3.V0.Lib;

namespace Tyuiu.OsipenkoAA.Sprint0.Task3.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckValid()
        {
            Assert.AreEqual(10, DataService.Sum(5, 5));
        }
    }
}
