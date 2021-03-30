using System;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductDictionary<string> Product = new ProductDictionary<string>();
            Product.Add("Fındık");

            Console.WriteLine("Liste Eleman Sayısı : " + Product.Length);

            Product.Add("Antep Fıstığı");
            Product.Add("Kaju");

            Console.WriteLine("Liste Eleman Sayısı : " + Product.Length);

            Console.WriteLine("-----------------------------------------------");

            Console.WriteLine("Ürün Listesi İçeriği");
            foreach (var product in Product.Items)
            {
                Console.WriteLine(product);
            }
        }
    }
}
