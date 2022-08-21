using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpProgram
{
    public class CodingPractice
    {
        public void prime()
        {
            int number; int count = 0;
            Console.WriteLine("Enter the Number");
            number = int.Parse(Console.ReadLine());

            for (int i = 1; i <= number; i++)
            {

                if (number % i == 0)
                {
                    count++;

                }
            }

            if (count == 2)
            {
                Console.WriteLine("Entered number is prime");

            }
            else
            {
                Console.WriteLine("Entered number is not a prime");
            }
            Console.WriteLine("Print All the Prime number b/w 1 to 100");
        }
        public void prime1()
        {
            for (int number = 1; number <= 100; number++)
            {
                int count = 0;

                for (int i = 1; i <= number; i++)
                {

                    if (number % i == 0)
                    {
                        count++;

                    }
                }
                if (count == 2)
                {
                    Console.WriteLine(number);
                }
            }
        }
        public void Armstrong()
        {
            int number = 153;
            int result = 0;
            int cube;
            int rem;
            int temp = number;

            while (number != 0)
            {
                rem = number % 10;
                cube = rem * rem * rem;
                result = result + cube;
                number = number / 10;
            }
            number = temp;
            if (number == result)
            {
                Console.WriteLine("Armstrong");
            }
            else
            {
                Console.WriteLine("not Armstrong");
            }
        }
        public void Palindrone()
        {

        }
        public void Fibonocci()
        {

        }
        public void Anagram()
        {

        }
        public void Factorial()
        {

        }

    }
}
