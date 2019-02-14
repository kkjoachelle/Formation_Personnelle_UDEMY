using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String
{
    class Program
    {
        static void Main(string[] args)
        {

            string FirstName = "Koffi";
            var LastName = "Kouadio Joachim";
            var FullName = FirstName + " " + LastName;

            var myFullnName = string.Format("my Name is {0} {1}", FirstName, LastName);

            Console.WriteLine("----------------------");
            var TabName = new string[] { "Koffi", "Adjoua", "Sietipka" };
            var myFullnName1 = string.Join(",",TabName);
            Console.WriteLine("Le resultat de la jointure est "+ myFullnName1);

            Console.WriteLine("----------------------");
            var MultLigne = "\n Koffi \n Adjoua \n Sietipka";
            Console.WriteLine("Le resultat est  " + MultLigne);
            /*
                 Voir video fondammental section 4, session 33
                var FullName = string.Concat
                var FullName = string.Format
                var FullName = string.Join
                var FullName = string.Equals

               */

            Console.ReadKey();
        }
    }
}
