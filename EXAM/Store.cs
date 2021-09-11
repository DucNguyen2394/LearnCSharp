using System;
using System.Collections.Generic;
using System.Text;

namespace EXAM
{
    class Store
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public float Price { get; set; }
        public Store() { }
        public Store(string id, string name, float price)
        {
            this.Id = id;
            this.Name = name;
            this.Price = price;
        }

        public void Input()
        {
            Console.WriteLine("Enter product Id : ");
            Id = Console.ReadLine();
            Console.WriteLine("Enter product name : ");
            Name = Console.ReadLine();
            Console.WriteLine("Enter product price : ");
            Price = float.Parse(Console.ReadLine());
        }

        public void Display()
        {
            Console.WriteLine("Product Id: {0}", Id);
            Console.WriteLine("Product name: {0}", Name);
            Console.WriteLine("Product price: {0}", Price);
            Console.WriteLine("==================================");
        }
    }
}
