// nhap vao 1 so >= 0 neu nhap sai nguyen tac thi nhap lai den khi dung thi thoi. Neu nhap dung thi tinh giai thua cua so
int n = -1;
while (n < 0)
{
    string input = Console.ReadLine();
    if (int.TryParse(input, out n) == true)
    {
        // nhap dung
        if (n >= 0)
        {
            break;
        }
        else
        {
            Console.WriteLine("nhap lon hon bang khong");
        }
    }
    else
    {
        // nhap sai
        Console.WriteLine("nhap sai");
    }
        
}

int gt = 1;
for (int i = 1; i<=n; i++)      
{
    gt *= i;
}
Console.WriteLine($"{n}! = {gt}");