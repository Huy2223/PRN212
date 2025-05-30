//Hãy cài đặt một hàm tính tuổi vào lớp Employee mà k đổi code cũ

using System.Text;
using OOP2;
Console.OutputEncoding = Encoding.UTF8;
FullTimeEmployee employee = new FullTimeEmployee
{
    Id = 1,
    IdCard = "123456789",
    Name = "Nguyen Van A",
    Birthday = new DateTime(1990, 1, 1)
};
Console.WriteLine("Thông tin nhân viên:");
Console.WriteLine(employee);
Console.WriteLine("==>Age=" + employee.TinhTuoi());