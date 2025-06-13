using DemoLINQ2SQL;
using System.Text;

Console.OutputEncoding = Encoding.UTF8;
string connectionString = "server=LAPTOP-K1DQ5ANF;database=MyStore;uid=sa;pwd=12345";
MyStoreDataContext context = new MyStoreDataContext(connectionString);
//Cau 1: Truy van toan bo danh muc
var dsdm = context.Categories.ToList();
Console.WriteLine("Danh sách toàn bộ danh mục");
dsdm.ForEach(x => Console.WriteLine($"{x.CategoryID} - {x.CategoryName} "));

//Câu 2: dùng queary syntax để lọc toàn bộ sản phẩm
var dsp = from p in context.Products
            select p;
Console.WriteLine("Danh sách toàn bộ sản phẩm");
foreach (var p in dsp)
{
    Console.WriteLine($"{p.ProductID} - {p.ProductName} - {p.UnitPrice} - {p.UnitsInStock}");
}

//Câu 3: Tìm danh mục khi biết mã danh mục
int mdm = 3;
Category category = context.Categories.FirstOrDefault(c => c.CategoryID == mdm);
if(category != null)
{
    Console.WriteLine($"Danh mục có mã {mdm} là: {category.CategoryName}");
}
else
{
    Console.WriteLine($"Không tìm thấy danh mục có mã {mdm}");
}


//Câu 4: Lọc ra Top 3 sản phẩm có giá lớn nhất
var top3Products = context.Products
    .OrderByDescending(p => p.UnitPrice).Take(3);
Console.WriteLine("Top 3 sản phẩm có giá lớn nhất:");
foreach(var product in top3Products)
{
    Console.WriteLine($"{product.ProductID} - {product.ProductName} - {product.UnitPrice}");
}

//Câu 5: thêm 1 danh mục
//Category c1 = new Category
//{
//    CategoryName = "Thời trang"
    
//};
//context.Categories.InsertOnSubmit(c1);
//context.SubmitChanges();

//Câu 6: sửa tên danh mục
//Bước 1: tìm danh mục
//Bước 2: tìm thấy thì sửa

Category c13 = context.Categories.FirstOrDefault(c => c.CategoryID == 13);
if (c13 != null)
{
    c13.CategoryName = "Hàng GIa dụng";
    context.SubmitChanges();
}

//Câu 7: Xóa danh mục khi biết mã danh mục
Category c12 = context.Categories.FirstOrDefault(c => c.CategoryID == 12);
if (c12 != null)
{
    context.Categories.DeleteOnSubmit(c12);
    context.SubmitChanges();
}

//Câu 8: Xóa tất cả danh mục chưa có bất kì sản phẩm nào
var dssp_empty_product = context.Categories.Where(c => c.Products.Count() == 0).ToList();
context.Categories.DeleteAllOnSubmit(dssp_empty_product);
context.SubmitChanges();


//Câu 9: Thêm nhiều danh mục cùng 1 lúc
List<Category> dsdm_new = new List<Category>();
dsdm_new.Add(new Category()
{
    CategoryName = "Hàng điện tử"
});
dsdm_new.Add(new Category()
{
    CategoryName = "Hàng Hóa Chất"
});
dsdm_new.Add(new Category()
{
    CategoryName = "Hàng gia dụng"
});
context.Categories.InsertAllOnSubmit(dsdm_new);
context.SubmitChanges();