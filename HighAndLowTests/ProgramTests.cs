using Microsoft.VisualStudio.TestTools.UnitTesting;
using HighAndLow;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HighAndLow.Tests
{
    [TestClass()]
    public class ProgramTests
    {
        [TestMethod()]
        public void HighAndLowTest()
        {
            //Assert.Fail();
            Assert.AreEqual("42 -9", Program.HighAndLow("8 3 -5 42 -1 0 0 -9 4 7 4 -4"));
            Assert.AreEqual("42 -9", Program.HighAndLow("0 999 8888 sss"));

        }
    }
}