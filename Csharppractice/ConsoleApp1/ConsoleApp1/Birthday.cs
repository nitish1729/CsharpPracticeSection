using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpProgram
{
    public class Birthday
    {
        public void Bday()
        {
            Console.BackgroundColor = ConsoleColor.Green;
            Console.ForegroundColor = ConsoleColor.Red;
            string str3 = @"                Happy***
                     Happy ****** Nitish
                        Birthday *****
                                Nitish********Happy Birthday Nitish            #NitishBirthday                     ****Birthday***      HappyBirthdayNitish" ;
            //for (int i = 0; i <= 5; i++)
            //{
            //    for (int j = 0; j < i; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}
            //for (int i = 0; i <=3; i++)
            //{
            //    for (int j = i; j < 3; j++)
            //    {
            //        Console.Write(str3);
            //    }
            //    Console.WriteLine();
            //}
            string str2 = @"                 Happy
                     Happy
                        Birthday 
                                Nitish";
            ////Console.WriteLine(str2);
            //Console.WriteLine(str3);
            for (int i = 0; i <= 4; i--)
            {
                for (int j = i; j <= 5; j++)
                {
                    Console.Write("");
                }
                for (int k = 1; k <= i; k++)
                {
                    Console.Write("*");
                    Console.Write(str2);
                }
                Console.WriteLine("***");
                Console.WriteLine(str3);
                Console.WriteLine("Hello Nitish ");
            }
            Console.ReadLine();
        }
    }
}
