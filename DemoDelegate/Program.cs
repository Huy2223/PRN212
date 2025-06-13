using System.Text;

class Program
{
    public delegate int MyDelegate(int a, int b);
    static int Cong(int a, int b)
    {
        return a + b;
    }

    static int Tru(int a, int b)
    {
        return a - b;
    }

    public delegate int[] MyDelegate2(int n);
    static int[] DanhSachSoChan(int n)
    {
        List<int> list = new List<int>();
        for (int i = 0; i <= n; i++)
        {
            if (i % 2 == 0)
            {
                list.Add(i);
            }
        }
        return list.ToArray();
    }

    static int[] DanhSachSoNguyenTo(int n)
    {
        List<int> list = new List<int>();
        for (int i = 2; i <= n; i++)
        {
            bool isPrime = true;
            for (int j = 2; j <= Math.Sqrt(i); j++)
            {
                if (i % j == 0)
                {
                    isPrime = false;
                    break;
                }
            }
            if (isPrime)
            {
                list.Add(i);
            }
        }
        return list.ToArray();
    }
    public static void Main(string[] args)
    {
        Console.OutputEncoding  = Encoding.UTF8;
        MyDelegate d1 = new MyDelegate(Cong);
        Console.WriteLine("Tổng của 5 và 8 =" + d1(5, 8));
        d1 = new MyDelegate(Tru);
        Console.WriteLine("Hiệu của 5 và 8 =" + d1(5, 8));

        MyDelegate2 d2 = new MyDelegate2(DanhSachSoChan);
        int[] arr = d2(10);
        Console.WriteLine("Danh sách số chẵn:");
        foreach(int i in arr)
        {
            Console.Write(i + " ");
        }

        d2 = new MyDelegate2(DanhSachSoNguyenTo);
        arr = d2(20);
        Console.WriteLine("Danh sách số nguyên tố:");
        foreach (int i in arr)
        {
            Console.Write(i + " ");
        }
    }
}