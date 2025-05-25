Console.OutputEncoding = System.Text.Encoding.UTF8;
void do_calculate(double a, double b, string op)
{
    switch (op)
    {
        case "+":
            Console.WriteLine("{0} + {1} = {2}", a, b, a + b);
            break;
        case "-":
            Console.WriteLine("{0} - {1} = {2}", a, b, a - b);
            break;
        case "*":
            Console.WriteLine("{0} * {1} = {2}", a, b, a * b);
            break;
        case "/":
            Console.WriteLine("{0} / {1} = {2}", a, b, a / b);
            break;
        default:
            Console.WriteLine("Invalid operator");
            break;  
    }
}
Console.WriteLine("Simple Calculation!");
Console.WriteLine("Enter first number:");
double a= Double.Parse(Console.ReadLine());
Console.WriteLine("Enter second number:");
double b = Double.Parse(Console.ReadLine());
Console.WriteLine("Enter op :");
String op = Console.ReadLine();
do_calculate(a, b, op);
Console.ReadLine();