using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsComposite
{
    public class SoldierUnit : UnitInterface
    {
        public void Add(UnitInterface unit)
        {
            
        }

        public int GetPower()
        {
            return 1;
        }

        public List<UnitInterface> GetUnits()
        {
            return new List<UnitInterface>();
        }
        public override string ToString()
        {
            return "Un soldado";
        }
    }
}
