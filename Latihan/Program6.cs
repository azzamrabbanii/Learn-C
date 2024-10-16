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

            // int[] bilangan = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            // int totalGenap = 0;
            // int totalGanjil = 0;

            // for (int i = 0; i < bilangan.Length; i++)

            // {
            //     if (i % 2 == 0)
            //     {   
            //         Console.WriteLine(bilangan[i] + " adalah bilangan genap");
            //         totalGanjil++;
            //     }
            //     else 
            //     {
            //         Console.WriteLine(bilangan[i] + " adalah bilangan ganjil");
            //         totalGenap++;
            //     }
            // }
            // Console.WriteLine();
            // Console.WriteLine($"Total bilangan genap: {totalGenap}");
            // Console.WriteLine($"Total bilangan ganjil: {totalGanjil}");

            // int[] angka = {-1,-23,-45,1,23,35,52};
            // int terbesar = angka[0];

            // for (int i = 0; i < angka.Length;  i++){
            //     if(angka[i] < 0) {
            //         continue;
            //     }

            //     if(angka[i] > terbesar) {
            //         terbesar = angka[i];
            //     }

            // }
            // Console.WriteLine($"Bilangan terbesar dalam array adalah: {terbesar}");

            int[] numbers = { -10, -5, -7, -100};
            int? largest = null;

            for (int i = 0; i < numbers.Length; i++)
            {
                // Melewatkan bilangan negatif
                if (numbers[i] < 0)
                {
                    continue;
                }

                // Jika bilangan adalah kelipatan 5, hentikan pencarian dan kembalikan bilangan tersebut
                if (numbers[i] % 5 == 0)
                {
                    largest = numbers[i];
                    break; // Menghentikan pencarian karena menemukan kelipatan 5
                }

                // Menentukan bilangan terbesar
                if (largest == null || numbers[i] > largest)
                {
                    largest = numbers[i];
                }
            }

            // Jika largest masih null, berarti semua bilangan negatif atau array kosong
            if (largest == null)
            {
                Console.WriteLine("Semua bilangan negatif atau array kosong.");
            }
            else
            {
                Console.WriteLine($"Bilangan terbesar adalah: {largest}");
            }

        }
    }
}

