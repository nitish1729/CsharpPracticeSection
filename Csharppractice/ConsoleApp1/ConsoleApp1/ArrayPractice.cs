using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpProgram
{
    public class ArrayPractice
    {
        public void Arrays()
        {
            int[] arr1 = new int[5] { 10, 20, 30, 40, 50 };
            string[] arr2 = new string[] { "Nitish", "Saurav", "Abhijeet", "Prakash" };
            char[] arr3 = { 'a', 'B', 'C', 'D', 'e' };
            try
            {


                for (int i = 1; i < arr1.Length; i++)
                {
                    Console.WriteLine(arr1[i]);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.WriteLine(arr2[0]);
            Console.WriteLine(arr2.Length);
            Console.WriteLine(arr2[0]);
            Console.WriteLine(arr2[3]);
            Console.WriteLine(arr3);
            Console.WriteLine(arr3[1]);
        }
        // C# Passing Array to Function
        public void ArryFunction(int[] Arr)
        {
            Console.WriteLine("Printing array elements:");
            for (int i = 0; i < Arr.Length; i++)
            {
                Console.WriteLine(Arr[i]);
            }
            Console.WriteLine("Array Index Value on 0 = " + Arr[0]);
        }
        public void printMin(int[] arr)
        {
            int min = arr[0];
            int max = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (min > arr[i])
                {
                    min = arr[i];
                }
                while (max < arr[i])
                {
                    max = arr[i];
                }

            }
            Console.WriteLine("Maximum element is: " + max);
            Console.WriteLine("Minimum element is: " + min);
        }
        public void MultiDArray()
        {
            int[,] MDArr = new int[3, 2] { { 5, 10 }, { 15, 20 }, { 50, 60 } }; //declaration and initialization
            string[,] MDArr1 = new string[3, 2] { { "Nitish", "Mehta" }, { "Bangalore", "Btm layout" }, { "Karntaka", "Mango" } };                                                  //Console.WriteLine(arr2d[0, 0]);
            Console.WriteLine(MDArr[0, 0]);
            Console.WriteLine(MDArr[0, 1]);
            Console.WriteLine(MDArr[1, 0]);
            Console.WriteLine(MDArr[1, 1]);
            Console.WriteLine(MDArr[2, 0]);
            Console.WriteLine(MDArr[2, 1]);
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.Write(MDArr[i, j] + " ");
                }
                Console.WriteLine();//new line at each row  

            }
        }

        public void Arrayclass()
        {

            int[] arr = new int[6] { 5, 8, 9, 25, 0, 7 };
            int[] arr2 = new int[6];
            // Displaying length of array  
            Console.WriteLine("length of first array: " + arr.Length);
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
            Array.Sort(arr);
            Console.Write("First array elements: ");

            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
            Array.Reverse(arr);
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }

        public void Arguments()
        {
            //    // Command line arguments  
            //    Console.WriteLine("Argument length: " + args.Length);
            //    Console.WriteLine("Supplied Arguments are:");
            //    foreach (Object obj in args)
            //    {
            //        Console.WriteLine(obj);
            //    }
        }

    }
}
