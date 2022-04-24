using Homework25._4._2022.Enums;
using Homework25._4._2022.Models;
using System;

namespace Homework25._4._2022
{
    class Program
    {
        static void Main(string[] args)
        {
            Products product = new Products(ProductType.Bakery,"Kepekli corek", 2 , 10);
            product.Test();
            product.Test();
            Products product2 = new Products(ProductType.Drink, "Bizom", 1 , 10);
            product2.Test();
           




        }
    }
}
