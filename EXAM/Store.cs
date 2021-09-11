using System;
using System.Collections.Generic;
using System.Text;

namespace EXAM
{
    class Store
    {
        private string id;
        private string name;
        private float price;
        public Store() { }
        public Store(string id, string name, float price)
        {
            this.id = id;
            this.name = name;
            this.price = price;
        }
        public string Id { get; set; }
        public string Name { get; set; }
        public string Price { get; set; }

        public void Input()
        {
            Console.WriteLine("Enter product Id : ");
            id = Console.ReadLine();
            Console.WriteLine("Enter product name : ");
            name = Console.ReadLine();
            Console.WriteLine("Enter product price : ");
            price = float.Parse(Console.ReadLine());
        }

        public void Display()
        {
            Console.WriteLine("Product Id: {0}", id);
            Console.WriteLine("Product name: {0}", name);
            Console.WriteLine("Product price: {0}", price);
            Console.WriteLine("==================================");
        }
    }
}
