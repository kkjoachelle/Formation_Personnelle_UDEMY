using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reference_Type__and_Value_Type
{
    class Program
    {
        private static int numbber;

        static void Main(string[] args)
        {
            /* 
               type valeurs 
                int
                char
                float
                bool
                Structures
                ...
                */

            /* 
               type references 
                classes 
                array
                string
                ...
                */

            var a = 10;
            var b = a;
            var c = b++;
            Console.WriteLine(string.Format("a :  {0}, b : {1}",a ,b));
            Console.WriteLine(c);
            Console.WriteLine("-----------------reference valeur");
            var number = 100;
            Increment(number);
            Console.WriteLine(number);

            Console.WriteLine("-----------------reference type");
            var pers = new Person();
            pers.Age = 20;
            MakeOld(pers);
            Console.WriteLine(pers.Age);

            Console.ReadKey();

        }
        public static void Increment(int number)
        {
            numbber += 10;
        }

        public static void MakeOld(Person person)
        {
            person.Age += 10;
        }
    }
}

