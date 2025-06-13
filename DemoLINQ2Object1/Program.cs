using System.Text;

Console.OutputEncoding = Encoding.UTF8;

int[] arr = { 20, 11, 30, 15, 40, 45, 73, 19, 50 };

//Câu 1: Lọc ra số chẵn dùng Extension method - Method Syntax
var ar_chan = arr.Where(x => x % 2 == 0);
Console.WriteLine("Các số chẵn dùng Method Syntax:");
ar_chan.ToList().ForEach(x => Console.WriteLine(x));
//Cách 2: Dùng query syntax
var ar_chan2 = from x in arr
               where x % 2 == 0
               select x;
Console.WriteLine("Các số chẵn dùng Query Syntax:");
ar_chan2.ToList().ForEach(x => Console.WriteLine(x));

//Câu 2: Tăng các phần tử lên 2 đơn vị
var arr2 = arr.Where(x => x %2 != 0)
              .Select(x => x + 2);
Console.WriteLine("Dữ liệu gốc:");
foreach (var x in arr)
{
    Console.WriteLine(x);
}

Console.WriteLine("Các số lẻ tăng lên 2 đơn vị:");
foreach (var x in arr2)
{
    Console.WriteLine(x);
}

//Câu 3: Sắp xếp các phần tử theo thứ tự tăng dần

var arr4 = arr.OrderBy(x => x);
var arr5 = from x in arr
           orderby x
           select x;

Console.WriteLine("Các phần tử sắp xếp theo thứ tự tăng dần:");
foreach (var x in arr5)
{
    Console.WriteLine(x);
}

//Câu 4: Sắp xe xếp các phần tử theo thứ tự giảm dần
var arr6 = arr.OrderByDescending(x => x);
var arr7 = from x in arr
           orderby x descending
           select x;
//Câu 5 đếm các phần tử lẻ
Console.WriteLine("Số lẻ là=" + arr.Where(x => x%2 !=0).Count());