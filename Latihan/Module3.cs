while (true)
{
    Console.WriteLine("Enter the triangle height : ");
    string? input = Console.ReadLine();
    if (int.TryParse(input, out int n) && n > 0)
    {
        for (int i = n; i > 0; i--)
        {
            for (int j = 0; j <= n - i; j++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
            Thread.Sleep(500);
        }
        break;
    }
    else
    {
        Console.WriteLine("Invalid input, please enter a real number.");
    }
}