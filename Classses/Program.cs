using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classses
{
    class Program
    {
        static void Main(string[] args)
        {
            var personne = new Person();
            personne.firstName = "koffi";
            personne.LastName = "kouadio joachim";
            personne.Introduce();

            int calculer = new Calculator().Add(10, 20);
            Console.WriteLine("Le resultats est "+calculer);

            Console.ReadKey();
        }
    }
   

}
