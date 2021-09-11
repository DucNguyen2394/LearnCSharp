using System;
using System.Collections.Generic;

namespace EXAM
{
    class Program
    {
        static List<Store> stores = new List<Store>();
        static void Main(string[] args)
        {
            int choose;
            do
            {
                ShowMenu();
                choose = int.Parse(Console.ReadLine());
                switch(choose)
                {
                    case 1:
                        Add();
                        break;
                    case 2:
                        ShowProduct();
                        break;
                    case 3:
                        DeleteById();
                        break;
                    case 4:
                        Console.WriteLine("Bye!");
                        break;
                    default:
                        Console.WriteLine("you choose wrong! Please choose again");
                        break;
                }
            } while (choose != 4);
        }
        static void ShowMenu()
        {
            Console.WriteLine("1. Add product records");
            Console.WriteLine("2. Display product records");
            Console.WriteLine("3. Delete product Id");
            Console.WriteLine("4. Exit");
        }

        static void Add()
        {
            String choose;
            while (true)
            {
                Store store = new Store();
                store.Input();

                stores.Add(store);

                Console.WriteLine("Ban co muon nhap tiep khong? Y/N");
                choose = Console.ReadLine();
                if (choose.Equals("N")) break;
            }
        }
        static void ShowProduct()
        {
            foreach (Store item in stores)
            {
                item.Display();
            }
        }
        static void DeleteById()
        {
            Console.WriteLine("Enter product id you need delete : ");
            string id = Console.ReadLine();
            for(int i = 0; i < stores.Count; i++)
            {
                if (stores[i].Id.Equals(id))
                {
                    stores.RemoveAt(i);
                }
            }
        }

    }
}
