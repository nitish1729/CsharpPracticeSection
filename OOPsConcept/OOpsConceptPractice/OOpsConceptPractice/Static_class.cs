using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPsConcept
{
    public static class Static_class
    {
        public static int ProductId;
        public static string ProductName;
        public static int productPrice;

        static Static_class()
        {
            ProductId = 101;
            ProductName = "Laptop";
            productPrice = 500000;
        }
        public static void getproductDetails()
        {
            Console.WriteLine("Product Id = {0}", ProductId);
            Console.WriteLine("Product Name = {0}", ProductName);
            Console.WriteLine("Product Price = {0}", productPrice);
        }
        public static void getdiscount()
        {
            int PDiscount = productPrice / 10;
            Console.WriteLine("Product Discount Amount  = {0}",PDiscount);
            Console.WriteLine("Product totalprice = {0}", productPrice - PDiscount);
        }
        static void Main(string[] args)
        {
            Static_class.getproductDetails();
            Static_class.getdiscount();
            
        }
    }
}
