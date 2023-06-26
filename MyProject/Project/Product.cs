using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product
{
    public abstract class Product
    {
        protected string ProductId;
        protected string Name;
        protected double Price;
        protected string Producer;

        public Product(string productId, string name, double price, string producer)
        {
            ProductId = productId;
            Name = name;
            Price = price;
            Producer = producer;
        }
        public abstract double ComputeTax();
    }
    public class Book : Product
    {
        public Book(string productId, string name, double price, string producer)
              : base(productId, name, price, producer)
        { }
        public override double ComputeTax()
        {
            return Price * 0.08;
        }
    }
    public class MobilePhone : Product
    {
        public MobilePhone(string productId, string name, double price, string producer)
              : base(productId, name, price, producer)

        { }
        public override double ComputeTax()
        {
            return Price * 0.1;
        }

    }
}
