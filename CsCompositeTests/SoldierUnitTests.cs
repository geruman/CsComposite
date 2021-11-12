using Microsoft.VisualStudio.TestTools.UnitTesting;
using CsComposite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsComposite.Tests
{
    [TestClass()]
    public class SoldierUnitTests
    {
        private UnitInterface unit;
        [TestInitialize()]
        public void Initialize()
        {
            unit = new SoldierUnit();
        }
        [TestMethod()]
        public void AddTest()
        {
            unit.Add(new SoldierUnit());
            Assert.AreEqual(unit.GetUnits().Count, 0);
        }

        [TestMethod()]
        public void GetPowerTest()
        {
            Assert.AreEqual(unit.GetPower(), 1);
        }

        [TestMethod()]
        public void GetUnitsTest()
        {
            Assert.AreEqual(unit.GetUnits().Count, 0);
        }
    }
}