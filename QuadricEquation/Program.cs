using System.Text;

Console.OutputEncoding = Encoding.UTF8;
void first_degree_solution(double a, double b)
{
    if (a == 0)
    {
        if (b == 0)
        {
            Console.WriteLine("Phương trình vô số nghiệm");
        }
        else
        {
            Console.WriteLine("Phương trình vô nghiệm");
        }
    }
    else
    {
        double x = -b / a;
        Console.WriteLine("Phương trình có nghiệm x = {0}", x);
    }
}

void quadric_equation_solution(double a, double b, double c)
{
    if (a == 0)
    {
        first_degree_solution(b, c);
    }
    else
    {
        var delta = Math.Pow(b,2) - 4 * a * c;
        if (delta < 0)
        {
            Console.WriteLine("Vô nghiệm");

        } else if(delta == 0)
        {
            Console.WriteLine("X1=X2={0}", -b / (2 * a));
        }
        else
        {
            var x1 = (-b-Math.Sqrt(delta)) / (2*a);
            var x2 = (-b + Math.Sqrt(delta)) / (2 * a);
            Console.WriteLine("X1={0}\nX2{1}", x1,x2);
        }
    }
}
Console.WriteLine("Giải phương trình bậc 2");
Console.WriteLine("Nhập hệ số a:");
var a = double.Parse(Console.ReadLine());
Console.WriteLine("Nhập hệ số b:");
var b = double.Parse(Console.ReadLine());
Console.WriteLine("Nhập hệ số c:");
var c = double.Parse(Console.ReadLine());
quadric_equation_solution(a, b, c);
Console.ReadLine();