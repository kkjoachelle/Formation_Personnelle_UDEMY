using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variable_and_constants
{
    class Program
    {
        static void Main(string[] args)
        {
            byte number =  2;
            int count = 10;
            float  totalPrice = 20.95f;
            char Nom =  'a';
            string firstName = " joachim";
            bool absence = true;
 
            Console.WriteLine("number :Le reseultat est :" + number);
            Console.WriteLine("count :Le reseultat est :" + count);
            Console.WriteLine("totalPrice :Le reseultat est :" + totalPrice);
            Console.WriteLine("-----");
            Console.WriteLine("Nom :Le reseultat est :" + Nom);
            Console.WriteLine("firstName :Le reseultat est :" + firstName);
            Console.WriteLine("absence :Le reseultat est :" + absence);
            Console.WriteLine("-----");
            Console.WriteLine(" {0} est un caractère et {1} est une chaine de caractère", Nom, firstName);

            Console.ReadKey();
        }
    }
}
