using System;
using System.Linq;

namespace EntityFrameworkDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //GetAll();
           //GetProductsByCategory(1);

            using (NorthwindContext context = new NorthwindContext())
            {
                foreach (var item in context.Personels)
                {
                    Console.WriteLine(item.Name+" "+ item.Surname);
                }
            }
            Console.ReadLine();
        }

        private static void GetAll()
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                foreach (var item in context.Products)
                {
                    Console.WriteLine(item.ProductName);
                }
            }
        }

        private static void GetProductsByCategory(int cateogryId)
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                var result = context.Products.Where(p => p.CategoryId == cateogryId);
                foreach (var item in result)
                {
                    Console.WriteLine(item.ProductName);
                }
            }
        }

    }

}
