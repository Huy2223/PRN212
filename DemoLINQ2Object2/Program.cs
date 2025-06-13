using DemoLINQ2Object2;
using System.Text;

Console.OutputEncoding = Encoding.UTF8;
ListProduct lp = new ListProduct();
lp.Gen_Product();
//Câu 1: Lọc ra các sản phẩm có giá từ a đến b sử dung Method Syntax
var result1 = lp.FilterProductsByPrice(2000, 6000);
Console.WriteLine("Các sản phẩm có giá từ 2000 đến 6000 (Method Syntax):");
result1.ForEach(p => Console.WriteLine($"Id: {p.Id}, Name: {p.Name}, Quantity: {p.Quantity}, Price: {p.Price}"));

//Câu 2: Sap xep cac san pham giam dan
var result2 = lp.SortProductsDescending();
Console.WriteLine("Các sản phẩm sắp xếp theo giá giảm dần (Method Syntax):");
result2.ForEach(p => Console.WriteLine($"Id: {p.Id}, Name: {p.Name}, Quantity: {p.Quantity}, Price: {p.Price}"));

//Câu 3: Tính tổng giá trị sản phẩm
Console.WriteLine("Tổng giá trị" + result1);