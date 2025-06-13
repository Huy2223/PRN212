using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP5_Dictionary
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Dictionary<int, Product> Products { get; set; }

        public Category()
        {
            Products = new Dictionary<int, Product>();
        }

        //lam du CRUD

        public void AddProduct(Product p)
        {
            if (Products.ContainsKey(p.Id))
            {
                return;
            }
            Products.Add(p.Id, p);
        }
        public void PrintAllProduct()
        {
            foreach (KeyValuePair<int, Product> item in Products)
            {
                Product p = item.Value;
                Console.WriteLine(p);
            }

        }

        //Loc ra san pham co gia tu x den y

        public Dictionary<int, Product> FilterProductByPrice(double min, double max)
        {
            Dictionary<int, Product> result = new Dictionary<int, Product>();
            result = Products.Where(item => item.Value.Price >= min
            && item.Value.Price <= max).ToDictionary<int, Product>();
            return result;
        }

        //Sap xep san pham theo don gia tang dan
        public Dictionary<int, Product> SortProductByPrice()
        {
            return Products.OrderBy(item => item.Value.Price).ToDictionary<int, Product>();
        }

        //sap xem theo tang dan, neu don gia trung nhau thi sap xep theo so luong giam dan
        public Dictionary<int, Product> ConplexSort()
        {
            return Products.OrderByDescending(item => item.Value.Quantity)
                           .OrderBy(item => item.Value.Price)
                           .ToDictionary<int, Product>();
        }

        public bool UpdateProduct(Product p)
        {
            if (p == null) return false;
            if (Products.ContainsKey(p.Id) == false)
            {
                return false;
            }
            Products[p.Id] = p; // đè dữ liệu ô nhớ hiện tại
            return true;
        }

        public bool RemoveProduct(int id)
        {
            if (Products.ContainsKey(id) == false)
            {
                return false;
            }
            Products.Remove(id);
            return true;
        }

    }
}