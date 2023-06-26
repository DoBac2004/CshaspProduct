using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product
{
    class Program
    {

        public static void main(String[] args)
        {
            // Declare and create Product array of size 6
            Product[] products = new Product[6];

            // Create three Book objects
            products[0] = new Book("A1", "Book 1", 29.99, "Publisher 1");
            products[1] = new Book("A2", "Book 2", 19.99, "Publisher 2");
            products[2] = new Book("A3", "Book 3", 14.99, "Publisher 3");

            // Create three MobilePhone objects
            products[3] = new MobilePhone("M1", "Phone 1", 399.99, "Manufacturer 1");
            products[4] = new MobilePhone("M2", "Phone 2", 299.99, "Manufacturer 2");
            products[5] = new MobilePhone("M3", "Phone 3", 199.99, "Manufacturer 3");

            double totalPhone = 0;
            double totalBook = 0;

            int i = 0;
            while (i < products.Length)
            {
                Product Product = products[i];

                if (Product is Book)
                {
                    totalBook += Product.ComputeTax();
                }
                else if (Product is MobilePhone)
                {
                    totalPhone += Product.ComputeTax();
                }

                i++;
            }
            Console.WriteLine("Total tax of books :  " + totalBook);
            Console.WriteLine("Total tax of Phone :  " + totalPhone);
            Console.ReadLine();
        }
    }


}
