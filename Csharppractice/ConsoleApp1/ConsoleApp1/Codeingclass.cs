using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpProgram
{
    public class Codeingclass
    {
        public void prime()
        {
            //int number = 7;
            //int count = 0;
            //for (int i = 1; i <= number; i++)
            //{
            //    if (number % i == 0)
            //    {
            //        count++;
            //    }

            //}
            //if (count == 2)
            //{
            //    Console.WriteLine("prime number");
            //}
            //else
            //{
            //    Console.WriteLine("not a prime");
            //}
            //Fibonacci Series
            //int a = 0, b = 1;
            int sum = 0, number;
            Console.WriteLine("check Entered is prime or not ");
            Console.WriteLine("Enter the Number");
            number = int.Parse(Console.ReadLine());
            Console.WriteLine("Entered Number = " + number);
            Console.WriteLine("check Entered is prime or not ");

            //for (int i = 2; i < num; ++i)
            //{
            //    sum = a + b;
            //    Console.WriteLine("Fibonacci Series = " + sum);

            //    a = b;
            //    b = sum;

            //}
            for (int i = 1; i <= number; i++)
            {
                if (number % i == 0)
                {
                    sum++;
                }
            }
            if (sum == 2)
            {
                Console.WriteLine(number + " is a prime number.");
            }
            else
            {
                Console.WriteLine(number + " is not a prime.");
            }
            Console.ReadLine();


        }
        //Fibonacci Series

        public void Fibno()
        {
            Console.WriteLine("..................Fibonacci Series...................................");
            int a = 0, b = 1;
            int sum = 0, number;
            Console.WriteLine("Enter the Number");
            number = int.Parse(Console.ReadLine());
            Console.WriteLine("Entered Number = " + number);

            Console.WriteLine(a + "  " + b);
            for (int i = 2; i < number; i++)
            {
                sum = a + b;
                Console.WriteLine(sum);
                a = b;
                b = sum;
            }
        }

        // Palindrome number algorithm
        public void Palindrome()
        {
            Console.WriteLine("..................Palindrome number algorithm...................................");
            int sum = 0, number;
            int temp, remainder;
            Console.WriteLine("Enter the Number");
            number = int.Parse(Console.ReadLine());
            Console.WriteLine("Entered Number = " + number);
            temp = number;
            while (number > 0)
            {
                remainder = number % 10;
                Console.WriteLine("Number is remainder =" + remainder);
                sum = (sum * 10) + remainder;
                Console.WriteLine("Number is Sum(sum*10)+remainder = " + sum);
                number = number / 10;
                Console.WriteLine("Number is Quotient(number/10)  = " + number);
                Console.WriteLine(",,,,,,,,,,,,,,,,,, = ");
            }
            if (temp == sum)
                Console.Write("Number is Palindrome");
            else
                Console.Write("Number is not Palindrome");


        }
        public void Factorial()
        {
            Console.WriteLine("..................Factorial program...................................");
            int number; int fact = 1;
            Console.WriteLine("Enter the Number");
            number = int.Parse(Console.ReadLine());
            Console.WriteLine("Entered Number = " + number);
            for (int i = 1; i <= number; i++)
            {
                fact = fact * i;
            }
            Console.WriteLine("Factorial of " + number + " is: " + fact);
        }

        // Program to reverse number
        public void ReverseNum()
        {
            Console.WriteLine("..................reverse number...................................");
            int number, rem, reverse = 0, temp;
            Console.WriteLine("Enter the Number");
            number = int.Parse(Console.ReadLine());
            Console.WriteLine("Entered Number = " + number);
            temp = number;
            while (number != 0)
            {
                rem = number % 10;
                reverse = (reverse * 10) + rem;
                number = number / 10;

            }
            Console.WriteLine("Reversed Number: " + reverse);
        }
        // Program to Print Alphabet Triangle
        public void AlphabetTriangle()
        {
            char ch = 'A';
            int i, j, k, m;
            for (i = 1; i <= 26; i++)
            {
                for (j = 26; j >= i; j--)
                    Console.Write(" ");
                for (k = 1; k <= i; k++)
                    Console.Write(ch++);
                ch--;
                for (m = 1; m < i; m++)
                    Console.Write(--ch);
                Console.Write("\n");
                ch = 'A';
            }
        }
    }
}
