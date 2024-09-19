using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    internal class Product
    {
        private string product_name;
        private double price;
        private int discount;
        public Product() { }
        //3 parameter
        public Product (string product_name, double price, int discount )
        {
            this.product_name = product_name;
            this.price = price;
            this.discount = discount;
        }
        //2 parameter
        public Product(string product_name, double price)
        {
            this.product_name= product_name;
            this.price = price;
            this.discount = 0;
        }
        public string Product_Name { get; set; }
        public double Price { get; set; }
        public int Discount { get; set; } 
        
        private double getImportTax()
        {
            return (price * 10) / 100;
        }

        public void input()
        {
            Console.WriteLine("Please enter product's name : ");
            this.product_name = Console.ReadLine();
            Console.WriteLine("Please enter product's price : ");
            this.price = double.Parse( Console.ReadLine() );
            Console.WriteLine("Please enter product's discount :" );
            this.discount = int.Parse( Console.ReadLine() );
        }
        public void display()
        {
            Console.WriteLine($"Product name : {product_name}");
            Console.WriteLine($"Product price : {price}");
            Console.WriteLine($"Product discount : {discount}");
            Console.WriteLine($"Product tax : {getImportTax()}");
        }

    }
}
