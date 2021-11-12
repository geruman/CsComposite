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
    public class PortalUnitTests
    {
        private PortalUnit unit;
        [TestInitialize]
        public void Initialize()
        {
            unit = new PortalUnit();
            
        }
        [TestCleanup()]
        public void CleanUp()
        {
            unit = null;
        }
        [TestMethod()]
        public void PortalUnitTest()
        {
            Assert.AreEqual(unit.GetUnits().Count, 0);
        }

        [TestMethod()]
        public void AddTest()
        {
            Assert.IsTrue(true);
        }

        [TestMethod()]
        public void GetPowerTest()
        {
            unit.Add(new SoldierUnit());
            PortalUnit unit2 = new PortalUnit();
            unit2.Add(new SoldierUnit());
            unit.Add(unit2);
            Assert.AreEqual(unit.GetPower(), 4);
        }

        [TestMethod()]
        public void GetUnitsTest()
        {
            unit.Add(new SoldierUnit());
            PortalUnit unit2 = new PortalUnit();
            unit2.Add(new SoldierUnit());
            unit.Add(unit2);
            Assert.AreEqual(3, unit.GetUnits().Count);
        }
    }
}