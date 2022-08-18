using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using WindowsFormsApp1;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        [DataRow("20", "5", "4", "400")]
        [DataRow("10", "10", "10", "1000")]
        [DataRow("12", "7", "9", "756")]
        public void TestMethod1(string l, string b, string h, string expected)
        {
            var volumeCalc = new Shape();
            int length = Int32.Parse(l);
            int breadth = Int32.Parse(b);
            int height = Int32.Parse(h);
            int expectedRes = int.Parse(expected);

            var volume = volumeCalc.GetVolume(length, breadth, height );
            Assert.AreEqual(expectedRes, volume);

            //Single Test
            //var volume = volumeCalc.GetVolume(20, 15, 5);
            //Assert.AreEqual(1500, volume);

        }
    }
}
