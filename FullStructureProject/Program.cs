Console.OutputEncoding = System.Text.Encoding.UTF8;
namespace FullStructureProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Cha mẹ \"thói đời\" ăn ở bạc");
            Console.WriteLine("Có chồng cà chớn cũng như không!");
            Console.WriteLine("Các đối số đầu vào của bạn: ");
            for (int i = 0; i < args.Length; i++) { 
                 Console.WriteLine(args[i]);
            }
            Console.ReadLine();
        }
        
    }
}