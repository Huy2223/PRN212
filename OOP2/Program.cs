using OOP2;

Console.OutputEncoding = System.Text.Encoding.UTF8;
FullTimeEmployee binladen = new FullTimeEmployee()
{
    Id = 1,
    IdCard = "123",
    Name = "Osama Bin Laden",
    Birthday = new DateTime(1957, 3, 10),

};
Console.WriteLine("Thong Tin cua Bin Gay");
Console.WriteLine($"Id={binladen.Id}");
Console.WriteLine("Name= " + binladen.Name);
Console.WriteLine("IdCard= " + binladen.IdCard);
Console.WriteLine("Nam Sinh= " + binladen.Birthday.ToString("dd/MM/yyyy"));
Console.WriteLine("Muc luong binladen nhan= " + binladen.calSalary());

PartTimeEmployee trumpbeo = new PartTimeEmployee()
{
    Id = 2,
    IdCard = "456",
    Name = "Donald Trump",
    Birthday = new DateTime(1946, 6, 14),
    WorkingHours = 3
};

Console.WriteLine("Thong tin cua Trump Beo");
Console.WriteLine($"Id={trumpbeo.Id}");
Console.WriteLine("Name= " + trumpbeo.Name);
Console.WriteLine("IdCard= " + trumpbeo.IdCard);
Console.WriteLine("Nam Sinh= " + trumpbeo.Birthday.ToString("dd/MM/yyyy"));
Console.WriteLine("Muc luong binladen nhan= " + trumpbeo.calSalary());

Console.WriteLine("Su dung toString");
Console.WriteLine(binladen);
Console.WriteLine(trumpbeo);