using System;

namespace odev2
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.ProductID = 1;
            product1.ProductName = "Mekanik Klavye";
            product1.ProductBrand = "HyperX";
            product1.ProductCategory = "Klavye";
            product1.ProductPrice = 1000;

            Product product2 = new Product();
            product2.ProductID = 2;
            product2.ProductName = "Yüksek DPI Mouse";
            product2.ProductBrand = "Logitech";
            product2.ProductCategory = "Mouse";
            product2.ProductPrice = 750;

            Product product3 = new Product();
            product3.ProductID = 3;
            product3.ProductName = "240HZ Monitör";
            product3.ProductBrand = "Asus";
            product3.ProductCategory = "Ekran";
            product3.ProductPrice = 5000;

            Product product4 = new Product();
            product4.ProductID = 4;
            product4.ProductName = "7.1 Kulaklık";
            product4.ProductBrand = "HyperX";
            product4.ProductCategory = "Kulaklık";
            product4.ProductPrice = 1500;

            Product product5 = new Product();
            product5.ProductID = 5;
            product5.ProductName = "Bluetooth Kulaklık";
            product5.ProductBrand = "Logitech";
            product5.ProductCategory = "Kulaklık";
            product5.ProductPrice = 3000;

            Product[] products = new Product[] { product1, product2, product3, product4, product5 };

            ProductList productList = new ProductList();

            productList.listProductWithForeach(products);
            productList.listProductWithFor(products);
            productList.listProductWithWhile(products);

            Console.ReadLine();
            

        }
    }

    class Product
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public string ProductBrand { get; set; }
        public string ProductCategory { get; set; }
        public int ProductPrice { get; set; }

       

    }

    class ProductList
    {
        public void listProductWithForeach(Product[] product)
        {
            Console.WriteLine("With Foreach Loop");

            foreach (Product productt in product)
            {
                Console.WriteLine(productt.ProductID + " => " + productt.ProductName + " => " + productt.ProductBrand + " => " + productt.ProductCategory + " => " + productt.ProductPrice);
            }
        }

        public void listProductWithFor(Product[] product)
        {
            Console.WriteLine("With For Loop");
            for (int i = 0; i < product.Length; i++)
            {
                Console.WriteLine(product[i].ProductID + " => " + product[i].ProductName + " => " + product[i].ProductBrand + " => " + product[i].ProductCategory + " => " + product[i].ProductPrice);
            }
        }

        public void listProductWithWhile(Product[] product)
        {
            Console.WriteLine("With While Loop");

            int i = 0;
            while (product.Length > i)
            {
                Console.WriteLine(product[i].ProductID + " => " + product[i].ProductName + " => " + product[i].ProductBrand + " => " + product[i].ProductCategory + " => " + product[i].ProductPrice);
                i++;
            }
        }
    }
}
