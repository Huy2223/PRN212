using DemoLINQ2Object;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLINQ2Object2
{
    public class ListProduct
    {
        List<Product> products;
        public ListProduct()
        {
            products = new List<Product>();

        }
        public void Gen_Product()
        {
            products.Add(new Product { Id = 1, Name = "Iphone 14", Quantity = 10, Price = 2000 });
            products.Add(new Product { Id = 2, Name = "Iphone 15", Quantity = 20, Price = 3000 });
            products.Add(new Product { Id = 3, Name = "Iphone 16", Quantity = 30, Price = 4000 });
            products.Add(new Product { Id = 4, Name = "Iphone 17", Quantity = 40, Price = 5000 });
            products.Add(new Product { Id = 5, Name = "Iphone 18", Quantity = 50, Price = 6000 });
            products.Add(new Product { Id = 6, Name = "Iphone 19", Quantity = 60, Price = 7000 });
            products.Add(new Product { Id = 7, Name = "Iphone 20", Quantity = 70, Price = 8000 });
            products.Add(new Product { Id = 8, Name = "Iphone 21", Quantity = 80, Price = 9000 });
            products.Add(new Product { Id = 9, Name = "Iphone 22", Quantity = 90, Price = 10000 });
            products.Add(new Product { Id = 10, Name = "Iphone 23", Quantity = 100, Price = 11000 });
        }
        public List<Product> FilterProductsByPrice(double price1, double price2)
        {
            return products
                .Where(p => p.Price >= price1 && p.Price <= price2)
                .OrderBy(p => p.Price)
                .ToList();
        }
        public List<Product>FilterProductByPrice2(double price1, double price2)
        {
            var results = from p in products
                          where p.Price <= price1 && p.Price <= price2
                          select p;

            return results.ToList();

        }

        public List<Product> SortProductsDescending()
        {
            return products.OrderByDescending(p => p.Price)
                .ToList();
        }

        public List<Product> SoreProductDescending2()
        {
            var results = from p in products
                          orderby p.Price descending
                          select p;
            return results.ToList();
        }

        public double SumOfValue()
        {
            return products.Sum(p => p.Price * p.Quantity);
        }
    }
}