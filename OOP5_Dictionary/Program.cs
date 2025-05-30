using System.Text;
using OOP5_Dictionary;

Console.OutputEncoding = Encoding.UTF8;
Category c1 = new Category();
c1.Id = 1;
c1.Name = "Soda";


Product p1 = new Product();
p1.Id = 1;
p1.Name = "Coke";
p1.Quantity = 10;
p1.Price = 10;
c1.AddProduct(p1);


Product p2 = new Product();
p2.Id = 2;
p2.Name = "Pepsi";
p2.Quantity = 30;
p2.Price = 10;
c1.AddProduct(p2);


Product p3 = new Product();
p3.Id = 3;
p3.Name = "Monster";
p3.Quantity = 7;
p3.Price = 20;
c1.AddProduct(p3);

Product p4 = new Product();
p4.Id = 4;
p4.Name = "Red Bull";
p4.Quantity = 5;
p4.Price = 30;
c1.AddProduct(p4);

Product p5 = new Product();
p5.Id = 5;
p5.Name = "7 Up";
p5.Quantity = 15;
p5.Price = 10;
c1.AddProduct(p5);

//Xuat toan bo san pham nc ngot
Console.WriteLine("Danh sach nuoc ngot: ");
c1.PrintAllProduct();



Console.WriteLine("-----------------Cac San Phan Co Gia Tu 10 Den 20--------------------------");
Dictionary<int,Product> filters = c1.FilterProductByPrice(10, 20);
foreach(KeyValuePair<int,Product> kvp  in filters)
{
    Product p = kvp.Value;
    Console.WriteLine(p);
}


Dictionary<int, Product> sortedProducts = c1.SortProductByPrice();
Console.WriteLine("------------Sản phẩm sau khi sap xep-------------");
foreach (KeyValuePair<int,Product> kvp in filters)
{
    Product product = kvp.Value;
    Console.WriteLine(product);
}


Dictionary<int, Product> complexSortedProducts = c1.ConplexSort();
Console.WriteLine("------------Sản phẩm sau khi sap xep phuc tap-------------");
foreach (KeyValuePair<int, Product> kvp in complexSortedProducts)
{
    Product product = kvp.Value;
    Console.WriteLine(product);
}


p1.Name = "xá xị";
p1.Quantity = 20;
p1.Price = 29;
c1.UpdateProduct(p1);
Console.WriteLine("--------------San pham sau chinh sua -----------------");
c1.PrintAllProduct();


int id = 3;
bool ret = c1.RemoveProduct(id);
if (ret)
{
    Console.WriteLine($"Da xoa san pham co Ma {id} thanh cong");
}
else
{
    Console.WriteLine($"Khong tim thay san pham");
}


Category c2 = new Category();
c2.Id = 2;
c2.Name = "Beer";
c2.AddProduct(new Product() { Id = 6, Name = "333", Quantity = 10, Price = 6 });
c2.AddProduct(new Product() { Id = 7, Name = "Tiger", Quantity = 45, Price = 9 });

SortedSet<Category> ss = new SortedSet<Category>();
ss.Add(c2);
ss.Add(c1);
Console.WriteLine("------------All data by category----------");
foreach (Category c in ss)
{
    Console.WriteLine("--" + c.Name + "--");
    Console.WriteLine("***************");
    c.PrintAllProduct();
    Console.WriteLine("***************");
}