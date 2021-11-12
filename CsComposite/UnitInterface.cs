using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace CsComposite
{
    public interface UnitInterface
    {
        void Add(UnitInterface unit);
        List<UnitInterface> GetUnits();
        int GetPower();
    }
}
