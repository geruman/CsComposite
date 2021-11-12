using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsComposite
{
    class Program
    {
        static void Main(string[] args)
        {
            UnitInterface raiz = new PortalUnit();
            raiz.Add(new SoldierUnit());
            raiz.Add(new SoldierUnit());
            UnitInterface primerPortal = new PortalUnit();
            primerPortal.Add(new SoldierUnit());
            primerPortal.Add(new SoldierUnit());
            raiz.Add(primerPortal);
            Console.WriteLine("La raiz tiene un poder de " + raiz.GetPower());
            Console.WriteLine("la raiz tiene " + raiz.GetUnits().Count + " hijos");
            Console.WriteLine("Imprimiendo la raiz");
            Console.WriteLine(raiz.ToString());
            Console.WriteLine("Imprimiendo el primer portal");
            Console.WriteLine(primerPortal.ToString());
            Console.ReadKey();

        }
    }
}
