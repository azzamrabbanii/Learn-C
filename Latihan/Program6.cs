namespace MyApplication
{
    class Program6
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Mulai Program");
            // int i = 10;
            // while (i > 0)
            // {
            //     Console.Write(i); // Print the number

            //     // Print dots beside the number
            //     for (int j = 0; j < i; j++)
            //     {
            //         Console.Write("."); // Dots will be printed right beside the number
            //     }

            //     Console.WriteLine();

            //     i--;
            //     if (i == 0)
            //     {
            //         break;
            //     }
            //     Thread.Sleep(500);
            // }
            // Console.WriteLine("Selesai Program");

            // Console.Write("Masukkan sebuah angka: ");
            // int number = Convert.ToInt32(Console.ReadLine());

            // // Mengecek apakah bilangan genap atau ganjil
            // if (number % 2 == 0)
            // {
            //     Console.WriteLine($"{number} adalah bilangan genap.");
            // }
            // else
            // {
            //     Console.WriteLine($"{number} adalah bilangan ganjil.");
            // }

            int[] bilangan = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            for (int i = 0; i < bilangan.Length; i++)
                
            {
                if (i % 2 == 0)
                {   
                    Console.WriteLine(bilangan[i] + " adalah bilangan genap");
                }
                else
                {
                    Console.WriteLine(bilangan[i] + " adalah bilangan ganjil");

                }
                Thread.Sleep(500);
            }
        }
    }
}
