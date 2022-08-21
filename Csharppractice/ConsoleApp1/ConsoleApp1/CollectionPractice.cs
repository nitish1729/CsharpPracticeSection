using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpProgram
{
    public class CollectionPractice
    {
        // public void ArrayListt() {
        //{  // Added item in the Array list using Add Method
        //    ArrayList Array = new ArrayList();
        //    Array.Add("FirstName:- Nitish");
        //    Array.Add("LastName:- Mehta");
        //    Array.Add("Address:- BTM Layout 1st stage");
        //    Array.Add("State:- karnataka");
        //    Array.Add("City: -Bangalore");
        //    Array.Add("Zipcode:- 560068");
        //    Array.Add(8252669501);
        //    try {   
        //        foreach (var i in Array)
        //        {
        //            Console.WriteLine(i);

        //        }
        //        }

        //    catch(Exception ex)
        //    {

        //        Console.WriteLine(ex.Message);
        //    }
        //    Console.WriteLine(@"Added new item in 
        //         +
        //           the  array");
        //    Array.Add(10);
        //    Array.Insert(2, "BrotherName:- Satish");

        //    Array.Remove(2);
        //    foreach(var i in Array)
        //        {
        //        Console.WriteLine(i);

        //    }
        //    Console.WriteLine("Item on the 2nd index is BrotherName:- Satish, will be remove now");
        //    Array.Remove("BrotherName:- Satish");
        //    foreach (var i in Array)
        //    {
        //        Console.WriteLine(i);

        //    }
        //    //sort the list  

        //    Console.WriteLine("=========== Sorted List================");
        //    try
        //    {
        //        //remove first two item from Array list using index  
        //        Array.RemoveRange(0, 2);
        //        foreach (var i in Array)
        //        {
        //            Console.WriteLine(i);

        //        }
        //    }
        //    catch (Exception ex1)
        //    { Console.WriteLine(ex1.Message); }
        //    Console.ReadLine();
        // }
        public void HashTable()
        {
            Console.WriteLine(@"=========== Hashtable========Hashtable========");
            Console.WriteLine("=========== Print by keys=======");
            Hashtable Hash = new Hashtable();
            Hash.Add("FirstName", "Nitish");
            Hash.Add(2, 'M');
            Hash.Add("ZipCose", 560068);
            Hash.Add(4, 369);
            Hash.Add(5, 3.1454544);
            Hash.Add(6, 85647644.46554446464);
            Hash.Add(7, 8252669501);
            //  ICollection key = Hash.Keys;
            foreach (object key in Hash.Keys)
            {
                Console.WriteLine(
                    Hash[key]);

            }
            Console.WriteLine("=========== Print by Values=======");


            Hash.Add("FirstNamee", "Nitish");
            Hash.Add("Gender", 'M');
            Hash.Add("ZipCode", 560069);


            //foreach (object key in Hash.Keys)
            //{
            //    Console.WriteLine(key + "         " +" :--"+ Hash[key]);


            //}

            foreach (object value in Hash.Values)
            {
                Console.WriteLine(value);

            }
            Console.WriteLine("==If you want to print keys and value both==");
            Hash.Add("LastName", "Mehta");
            Hash.Add("Location", "BTM Layout 1st Stage");
            Hash.Add("City", "Bangalore");
            Hash.Add("Job", "Analyst");
            Hash.Add("Area", "BTM Layout");
            foreach (object key in Hash.Keys)
            {
                Console.WriteLine(key + "  " + " :--" + Hash[key]);
                Console.ReadLine();

            }
        }
    }
}
