// namespace MyApplication
// {
//     class Program6
//     {
//         static void Main(string[] args)
//         {
//             // Console.WriteLine("Mulai Program");
//             // int i = 10;
//             // while (i > 0)
//             // {
//             //     Console.Write(i); // Print the number

//             //     // Print dots beside the number
//             //     for (int j = 0; j < i; j++)
//             //     {
//             //         Console.Write("."); // Dots will be printed right beside the number
//             //     }

//             //     Console.WriteLine();

//             //     i--;
//             //     if (i == 0)
//             //     {
//             //         break;
//             //     }
//             //     Thread.Sleep(500);
//             // }
//             // Console.WriteLine("Selesai Program");

//             // Console.Write("Masukkan sebuah angka: ");
//             // int number = Convert.ToInt32(Console.ReadLine());

//             // // Mengecek apakah bilangan genap atau ganjil
//             // if (number % 2 == 0)
//             // {
//             //     Console.WriteLine($"{number} adalah bilangan genap.");
//             // }
//             // else
//             // {
//             //     Console.WriteLine($"{number} adalah bilangan ganjil.");
//             // }

//             // int[] bilangan = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

//             // int totalGenap = 0;
//             // int totalGanjil = 0;

//             // for (int i = 0; i < bilangan.Length; i++)

//             // {
//             //     if (i % 2 == 0)
//             //     {   
//             //         Console.WriteLine(bilangan[i] + " adalah bilangan genap");
//             //         totalGanjil++;
//             //     }
//             //     else 
//             //     {
//             //         Console.WriteLine(bilangan[i] + " adalah bilangan ganjil");
//             //         totalGenap++;
//             //     }
//             // }
//             // Console.WriteLine();
//             // Console.WriteLine($"Total bilangan genap: {totalGenap}");
//             // Console.WriteLine($"Total bilangan ganjil: {totalGanjil}");

//             // int[] angka = {-1,-23,-45,1,23,35,52};
//             // int terbesar = angka[0];

//             // for (int i = 0; i < angka.Length;  i++){
//             //     if(angka[i] < 0) {
//             //         continue;
//             //     }

//             //     if(angka[i] > terbesar) {
//             //         terbesar = angka[i];
//             //     }

//             // }
//             // Console.WriteLine($"Bilangan terbesar dalam array adalah: {terbesar}");

//             // int[] numbers = { -10, -5, -7, -100};
//             // int? largest = null;

//             // for (int i = 0; i < numbers.Length; i++)
//             // {
//             //     // Melewatkan bilangan negatif
//             //     if (numbers[i] < 0)
//             //     {
//             //         continue;
//             //     }

//             //     // Jika bilangan adalah kelipatan 5, hentikan pencarian dan kembalikan bilangan tersebut
//             //     if (numbers[i] % 5 == 0)
//             //     {
//             //         largest = numbers[i];
//             //         break; // Menghentikan pencarian karena menemukan kelipatan 5
//             //     }

//             //     // Menentukan bilangan terbesar
//             //     if (largest == null || numbers[i] > largest)
//             //     {
//             //         largest = numbers[i];
//             //     }
//             // }

//             // // Jika largest masih null, berarti semua bilangan negatif atau array kosong
//             // if (largest == null)
//             // {
//             //     Console.WriteLine("Semua bilangan negatif atau array kosong.");
//             // }
//             // else
//             // {
//             //     Console.WriteLine($"Bilangan terbesar adalah: {largest}");
//             // }

//             // for (int i = 5; i > 0; i--)
//             // {
//             //     for (int j = 0; j < 6 - i; j++)
//             //     {
//             //         Console.Write(".");
//             //     }
//             //     Console.WriteLine();
//             //     Thread.Sleep(500);
//             // }
//             // int n = 10; //number of rows

//             // int n = 5;

//             // for (int i = 1; i <= n; i++)
//             // {
//             //     for (int j = 1; j <= i; j++)
//             //     {
//             //         Console.Write("*");
//             //     }
//             //     Console.WriteLine();
//             //     Thread.Sleep(250);
//             // }
//             // for (int i = n - 1; i >= 1; i--)
//             // {
//             //     for (int j = 1; j <= i; j++)
//             //     {
//             //         Console.Write("*");
//             //     }
//             //     Console.WriteLine();
//             //     Thread.Sleep(250);
//             // }

//             // int x = 8;
//             // int y = 12;

//             // if (x < y && (x + y > 15))
//             // {
//             //     Console.WriteLine("Case A");
//             // }
//             // else if (y - x < 5)
//             // {
//             //     Console.WriteLine("Case B");
//             // }
//             // else
//             // {
//             //     Console.WriteLine("Case C");
//             // }

//             // int n = 20; 
//             // int count = 0;

//             // for (int i = 1; i <= n; i++)
//             // {
//             //     if (i % 2 == 0)
//             //     {
//             //         count = count + i; 
//             //     }
//             //     else
//             //     {
//             //         count = count - i; 
//             //     }
//             // }

//             // Console.WriteLine(count);

//             Console.WriteLine("Enter the triangle height : ");
//             string input = Console.ReadLine();

//             if (int.TryParse(input, out int n) && n > 0)
//             {
//                 for (int i = n; i > 0; i--)
//                 {
//                     for (int j = 0; j <= n - i; j++)
//                     {
//                         Console.Write("*");
//                     }
//                     Console.WriteLine();
//                     Thread.Sleep(500);
//                 }
//             }
//             else
//             {
//                 Console.WriteLine("Invalid input, please enter a real number.");
//             }
//         }
//     }
// }