void hinh1(int n)
{
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < n; j++)
        {
            if (j == 0 || i == j-3 || j == (n)    )// Fixed comparison operators
            {
                Console.Write("*");
            }
            else
            {
                Console.Write(" ");
            }
        }
        Console.WriteLine(); // Moved outside the inner loop
    }
}
hinh1(8);