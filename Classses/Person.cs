using System;

namespace Classses
{
    public class Person
    {
        public string firstName { get; set; }
        public string LastName { get; set; }

        public void Introduce()
        {
            Console.WriteLine("My Name is :" + firstName + "  " + LastName);
        }
    }
   

}
