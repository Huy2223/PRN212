using System.Text;
using OOP2;

Console.OutputEncoding = System.Text.Encoding.UTF8;

/*Sử dụng generic list để quản lí nhân sự
 * thực hiện đầy đủ tính năng CRUD
 * create -> thêm mới nhân sự
 * read -> đọc, truy vấn, tìm kiếm
 * update -> chỉnh sửa dữ liệu
 * delete -> xóa dữ liệu
 */

/*Câu 1: Dùng list tạo 5 employee trong đó 4 emp là chính thức 1 là thời vụ
 */

List<Employee> employees = new List<Employee>();
FullTimeEmployee e1 = new FullTimeEmployee();
e1.Id = 1;
e1.Name = "A";
e1.IdCard = "Card 1";
e1.Birthday = new DateTime(1990, 11, 29);
employees.Add(e1);

FullTimeEmployee e2 = new FullTimeEmployee();
e2.Id = 2;
e2.Name = "B";
e2.IdCard = "Card 2";
e2.Birthday = new DateTime(1995, 11, 29);
employees.Add(e2);

FullTimeEmployee e3 = new FullTimeEmployee();
e3.Id = 3;
e3.Name = "C";
e3.IdCard = "Card 3";
e3.Birthday = new DateTime(1990, 11, 2);
employees.Add(e3);

FullTimeEmployee e4 = new FullTimeEmployee();
e4.Id = 4;
e4.Name = "D";
e4.IdCard = "Card 4";
e4.Birthday = new DateTime(2000, 11, 2);
employees.Add(e4);


PartTimeEmployee e5 = new PartTimeEmployee();
e5.Id = 5;
e5.Name = "E";
e5.IdCard = "Card 5";
e5.WorkingHours = 3;
e5.Birthday = new DateTime(2004, 12, 2);
employees.Add(e5);

Console.WriteLine("----Employee List Method 1----");
employees.ForEach(emp => Console.WriteLine(emp));
Console.WriteLine("----Employee List Method 2----");
foreach (var employee in employees)
{
    Console.WriteLine(employee);
}

/*Lọc ra nhân sự chính thức và tính tổng lương*/

List<FullTimeEmployee> fe_list1 = employees.OfType<FullTimeEmployee>().ToList();
Console.WriteLine("----Fulltime Employee List Method 1----");
fe_list1.ForEach(emp => Console.WriteLine(emp));

List<FullTimeEmployee> fe_list2 = new List<FullTimeEmployee>();
foreach (var employee in employees)
{
    if (employee is FullTimeEmployee)
    {
        fe_list2.Add(employee as FullTimeEmployee);
    }

}
Console.WriteLine("----Fulltime Employee List Method 2----");
fe_list2.ForEach(emp => Console.WriteLine(emp));

//Tính tổng lương của nhân sự chính thức
double totalSalary = fe_list1.Sum(emp => emp.calSalary());
Console.WriteLine("Tổng lương của nhân sự chính thức: " + totalSalary);

//Sắp xếp danh sách nhân sự theo ngày sinh
for (int i = 0; i < employees.Count - 1; i++)
{
    for (int j = i + 1; j < employees.Count; j++)
    {
        if (employees[i].Birthday > employees[j].Birthday)
        {
            Employee temp = employees[i];
            employees[i] = employees[j];
            employees[j] = temp;
        }
    }
}

Console.WriteLine("----Employee List after sorting by Birthday----");
employees.ForEach(emp => Console.WriteLine(emp));

Console.WriteLine("Remove a employee with Id=4");
//Xóa nhân sự có Id=4
employees.Remove(e4);
Console.WriteLine("----Employee List after removing Id=4----");
employees.ForEach(emp => Console.WriteLine(emp));

Console.WriteLine("Update a employee with Id=3");
Console.WriteLine("Update Name of employee with Id=3");
Console.WriteLine("Enter new Name: ");
string newName = Console.ReadLine();
Employee empToUpdate = employees.FirstOrDefault(emp => emp.Id == 3);

empToUpdate.Name = newName;

employees.ForEach(emp => Console.WriteLine(emp));