using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsComposite
{
    public class PortalUnit : UnitInterface
    {
        private List<UnitInterface> units;

        public PortalUnit()
        {
            units = new List<UnitInterface>();
        }
        public void Add(UnitInterface unit)
        {
            units.Add(unit);
        }

        public int GetPower()
        {
            int total = 1;
            foreach(UnitInterface unit in units)
            {
                total += unit.GetPower();
            }
            return total;
        }

        public List<UnitInterface> GetUnits()
        {
            List<UnitInterface> unitsInPortal = new List<UnitInterface>();
            foreach(UnitInterface unit in units)
            {
                unitsInPortal.Add(unit);
                unitsInPortal.AddRange(unit.GetUnits());
            }
            return unitsInPortal;
        }
        public override string ToString()
        {
            string description = "Portal con";
            foreach(UnitInterface unit in units)
            {
                description += " " + unit.ToString();
            }
            return description;
        }
    }
}
