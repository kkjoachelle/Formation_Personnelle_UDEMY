using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENUM
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Enum.Parse
            Enum.GetValues
            Enum.GetNames
            Enum.GetName
            ............
            ............
             */
            var method = ShippingMethod.Express;
            Console.WriteLine("Voici le resultat "+method);
            Console.WriteLine();
            var methodVal = (int)ShippingMethod.Express;
            Console.WriteLine("Voici l valeur numérique de {0} en {1} ", methodVal, ShippingMethod.Express);
            Console.ReadKey();
            
        }
    }
    public enum ShippingMethod
    {
        RegularAirMail = 1,
        RegisterAirMail =2,
        Express =3
    }

}
