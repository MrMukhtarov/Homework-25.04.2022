using System;
using System.Collections.Generic;
using System.Text;
using Homework25._4._2022.Enums;
namespace Homework25._4._2022.Models
{
    class Products
    {
        public string Code { get; set; }

        public string Name { get; set; }

        public double Price { get; set; }

        public double DiscountPrice { get; set; }

        public int TotalCount { get; set; }

        public static int Count { get; set; }

        public static int Codee { get; set; } = 1000;

        public Products(ProductType type, string name, double price , int total)
        {
            Codee++;
            Count++;
            Count -= total;
            Name = name;
            Price = price;
            TotalCount = total;
            Code = type.ToString().Substring(0,1) + Codee.ToString();

            if(type == ProductType.Bakery)
            {
                Price = price - price * 10 / 100;
            }
        }
        public  void Test()
        {
            Console.WriteLine($" {Name} { " " } {Price} AZN { "  " } {Code}  TotalCount {TotalCount}");
        }
    }
}

