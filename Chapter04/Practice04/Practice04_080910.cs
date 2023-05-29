using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CSharpCourse_NetFrameWork
{
    class Product
    {
        public readonly int _pid;
        public readonly string _name;
        public readonly int _type;
        public double _price;
        public int _amount;
        Product()
        { _pid = 0; _name = String.Empty; _type = 0; _price = 0.0; _amount = 0; }
        Product(int pid, string name, int type, double price, int amount)
        {
            _pid = pid;
            _name = name;
            _type = type;
            _price = price;
            _amount = amount;
        }
    }

    class Storehouse
    {
        private Product[] products;
        public int number;

        public Storehouse(int n) {
            number = 0;
            products = new Product[n];
        }
        public bool Add(Product a) {
            if(this.number >= this.products.Length)
                return false;
            products[this.number++] = a;
            return true;
        }
        public Product GetProduct(string name) {
            foreach (var x in this.products)
                if(x._name== name) return x;
            return null;
        }
        public Product GetProducts(int pid) {
            foreach (var x in this.products)
                if (x._pid == pid) return x;
            return null;
        }

    }
    internal class Test4_8910
    {
        static void Main(string[] args)
        {
            
        }
    }
}
