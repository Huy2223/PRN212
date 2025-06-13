using Lucy_SalesManagement;

Console.OutputEncoding = System.Text.Encoding.UTF8;
string connectionString = "server=LAPTOP-K1DQ5ANF;database=Lucy_SalesData;uid=sa;pwd=12345";
Lucy_SalesDataDataContext context = new Lucy_SalesDataDataContext(connectionString);
int cusID = 1;
Customer cus = context.Customers.FirstOrDefault(c => c.CustomerID == cusID);
if(cus != null)
{
    Console.WriteLine($"Khách hàng có mã {cusID} là: {cus.ContactName}");
    
    //câu 2: lọc ra danh sách hóa đơn của khách hàng tìm thấy
    foreach (Order or in cus.Orders)
    {
        Console.WriteLine($"Hóa đơn {or.OrderID} của khách hàng {cus.ContactName}");
    }

    //Câu 3: nâng cấp câu 2
    // bổ sung thêm 1 cột hiện trị giá hóa đơn
    foreach (Order or in cus.Orders)
    {
        // Tính tổng giá trị hóa đơn từ các chi tiết đơn hàng
        decimal totalAmount = 0;
        foreach (Order_Detail detail in or.Order_Details)
        {
            decimal lineTotal = detail.UnitPrice * detail.Quantity * (1 - (decimal)detail.Discount);
            totalAmount += lineTotal;
        }

        Console.WriteLine($"Hóa đơn {or.OrderID} của khách hàng {cus.ContactName} có trị giá {totalAmount:N2}");
    }
}
else
{
    Console.WriteLine($"Không tìm thấy khách hàng có mã {cusID}");
}


