using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpProgram
{
    public class CollectionList
    {
        public void CList()
        {
            List<int> Numbers = new List<int>();
            Numbers.Add(10); // adding elements using add() method
            Numbers.Add(20);
            Numbers.Add(30);
            Numbers.Add(40);
            Numbers.Add(50);
            Numbers.Add(60);
            // Iterate list element using foreach loop  
            foreach (int item in Numbers)
            {
                Console.WriteLine(item);
            }
            List<string> Cars = new List<string>();
            Cars.Add("Safari");
            Cars.Add("Mercedes-Benz");
            Cars.Add("BMW 5 Series");
            Cars.Add("Tata");
            Cars.Add("Thar");
            Console.WriteLine("List string ");
            foreach (string car in Cars)
            {
                Console.WriteLine(car);
            }
            Console.WriteLine("List ......................................string ");
            var Cars1 = new List<string>();
            Cars1.Add("Safari");
            Cars1.Add("Mercedes-Benz");
            Cars1.Add("BMW 5 Series");
            Cars1.Add("Tata");
            Cars1.Add("Thar");
            foreach (var car1 in Cars1)
            {
                Console.WriteLine(car1);
            }
            Console.WriteLine("List ......................................string ");
            var names = new List<string>() { "Sonoo", "Vimal", "Ratan", "Love", "Seema", "Divya", "Nitish" };
            foreach (string BMW in names)
            {
                Console.WriteLine(BMW);
            }
            //Adding an Array in a List
            string[] arr2 = new string[] { "Nitish", "Saurav", "Abhijeet", "Prakash" };
            List<string> AddArray = new List<string>();
            // adding an array in a List
            AddArray.AddRange(arr2);
            var name = new List<string>();
            name.AddRange(AddArray);
            Console.WriteLine(AddArray.Count);
            Console.WriteLine(name.Count);
            //Insert Elements in List
            List<int> num = new List<int>() { 40, 80, 120, 160, 200, 240, 280, 300 };

            foreach (var p in num)
            {
                Console.WriteLine(p);
            }
            // inserts 60 at 1st index: after 40.
            Console.WriteLine("inserts 60 at 1st index: after 40.");
            num.Insert(1, 60);
            foreach (var p in num)
            {
                Console.WriteLine(p);
            }
            num.Remove(60); // removes the first 60 from a list
            num.RemoveAt(0);//removes the 1st element (index starts from 0)
            Console.WriteLine("removes the element from a list.");
            foreach (var p in num)
            {
                Console.WriteLine(p);
            }
            //Check Elements in List
            Console.WriteLine("Check element is preset in the list or not :- " + num.Contains(100));
            Console.WriteLine("Check element is preset in the list or not:- " + num.Contains(300));
        }
        // C# - ArrayList
        public void ArrayList()
        {
            ArrayList arlist = new ArrayList();

        }
    }
}
