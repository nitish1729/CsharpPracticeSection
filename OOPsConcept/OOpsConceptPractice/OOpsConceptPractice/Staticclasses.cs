using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPsConcept
{

    /*
         Classes that cannot be instantiated or inherited are known static class and the static keyword is used 
         before the class name that contains of static data members and static methods.

        it is not possible to create intance of static class by using new keyword. The main features of static classes are
        it can only contain static members.
        it can be instantiated or inherited and cannot contain instance consturctors. However developers can create static constructors to 
        initialize the static members.

     */
    public static class Staticclasses
    {
        static int x = 10, y;

        static void calcute()
        {
            y = x * x;
            Console.WriteLine(y);
        }
        static void Main(string[] args)
        {
            //function calling directly
            Staticclasses.calcute();
        }
    }
} 
