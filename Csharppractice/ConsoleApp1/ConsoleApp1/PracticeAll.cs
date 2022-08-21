using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpProgram
{
    public class PracticeAll
    {
        public void display()
        {
            string email1 = "nitishkm369@gmail.com";
            string email;
            string pass;
            string password = "Name@123";
            Console.WriteLine("Enter Your EmaiID");
            email = Console.ReadLine();
            //Console.WriteLine("Enter Your Password");
            //pass = Console.ReadLine();
            if (email == email1)
            {
                Console.WriteLine("Enter the pass");
                pass = Console.ReadLine();
                if (pass == password)
                {
                    Console.WriteLine("You have been logged in successfully");
                }
                else
                {
                    Console.WriteLine("Plase enter correct password");
                }
            }
            else
            {
                Console.WriteLine("Please enter corect Emial id");
            }


            //int x = 10, y = 100;

            //var result = x > y ? "x is greater than y" : "x is less than y";

            //Console.WriteLine(result);

            //Console.WriteLine("Enter a number:");
            //int num = Convert.ToInt32(Console.ReadLine());



        }
    }
}
