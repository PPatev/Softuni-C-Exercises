using System;
using System.Collections.Generic;
using System.Linq;

namespace _7._Andrey_and_Billiard
{
    class AndreyBilliard
    {
        static void Main(string[] args)
        {
            var items = new Dictionary<string, decimal>();
            var customers = new List<Customer>();
            var lines = int.Parse(Console.ReadLine());

            for (int i = 0; i < lines; i++)
            {
                var input = Console.ReadLine().Split('-');
                var item = input[0];
                var price = decimal.Parse(input[1]);
                if (!items.ContainsKey(item))
                {
                    items.Add(item, price);
                }
                else
                {
                    items[item] = price;
                }
                
            }

            var line = Console.ReadLine();
            while (line != "end of clients")
            {
                var input = line.Split('-');
                var name = input[0];
                var shop = input[1].Split(',');
                var item = shop[0];
                if (!items.ContainsKey(item))
                {
                    line = Console.ReadLine();
                    continue;
                }
                var quantity = int.Parse(shop[1]);
                var studentNames = customers.Select(c => c.Name);
                if (studentNames.Contains(name))
                {
                    var student = customers.Where(c => c.Name.Equals(name)).First();
                    var shopList = student.ShopList;
                    if (!shopList.ContainsKey(item))
                    {
                        shopList.Add(item, quantity);
                    }
                    else
                    {
                        var quan = shopList[item];
                        quan += quantity;
                        shopList[item] = quan;
                    }

                    student.ShopList = shopList;
                }
                else
                {
                    var shopList = new Dictionary<string, int>();
                    shopList.Add(item, quantity);
                    var student = new Customer();
                    student.Name = name;
                    student.ShopList = shopList;
                    customers.Add(student);
                }

                line = Console.ReadLine();
            }

            var bill = 0.0M;
            foreach (var student in customers.OrderBy(c => c.Name))
            {
                var name = student.Name;
                Console.WriteLine(name);
                var result = student.ShopList.Select(i => $"-- {i.Key} - {i.Value}");
                Console.WriteLine(string.Join(Environment.NewLine, result));
                var studentBill = student.ShopList.Select(i => items[i.Key] * i.Value).Sum();
                Console.WriteLine($"Bill: {studentBill:F2}");
                bill += studentBill;
            }

            Console.WriteLine($"Total bill: {bill:F2}");
        }
    }

    class Customer
    {
        public string Name { get; set; }
        public Dictionary<string, int> ShopList { get; set; }
        public decimal Bill { get; set; }
    }
}
