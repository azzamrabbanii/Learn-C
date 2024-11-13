// // See https://aka.ms/new-console-template for more information
// // Console.WriteLine("Hello, World!");
// using System;

// namespace MyApplication
// {
//     class Program
//     {
        
//         static void Main(string[] args)
//         {
//             // Console.WriteLine("Enter youAge:");

//             // int Age = Convert.ToInt32(Console.ReadLine());

//             // Console.WriteLine("Your Age: " + Age);

//             // Declaration of variables to store four numbers
//             // int number1, number2, number3, number4;

//             // Prompting the user to enter the first number
//             // Console.Write("Enter the First number: ");
//             // Reading the first number entered by the user and converting it to a double
//             // number1 = Convert.ToInt32(Console.ReadLine());

//             // Prompting the user to enter the second number
//             // Console.Write("Enter the Second number: ");
//             // Reading the second number entered by the user and converting it to a double
//             // number2 = Convert.ToInt32(Console.ReadLine());

//             // Prompting the user to enter the third number
//             // Console.Write("Enter the third number: ");
//             // Reading the third number entered by the user and converting it to a double
//             // number3 = Convert.ToInt32(Console.ReadLine());

//             // Prompting the user to enter the fourth number
//             // Console.Write("Enter the fourth number: ");
//             // Reading the fourth number entered by the user and converting it to a double
//             // number4 = Convert.ToInt32(Console.ReadLine());

//             // Calculating the average of the four numbers
//             // double result = (number1 + number2 + number3 + number4) / 4;

//             // // Displaying the average of the four numbers to the console
//             // Console.WriteLine("Total Average is: {4} ",
//             //     number1, number2, number3, number4, result);

//             // Get the current time
//             // DateTime currentTime = DateTime.Now;

//             // Print the current time using WriteLine
//             // string waktu;
//             // // Console.Write("What time is it : ");
//             // waktu = Convert.ToString(Console.ReadLine());

//             // Console.WriteLine("The current time is: " + currentTime.ToString("HH:mm:ss"));

//             // Using Switch/case
//             // Console.WriteLine("Pilih barang kamu 1-6 : ");
//             // int day = Convert.ToInt32(Console.ReadLine());
//             // switch (day)
//             // {
//             //     case 1:
//             //         Console.WriteLine("Pena tanpa tinta");
//             //         break;
//             //     case 2:
//             //         Console.WriteLine("Kursi tanpa dudukan");
//             //         break;
//             //     case 3:
//             //         Console.WriteLine("Jam tanpa jarum");
//             //         break;
//             //     case 4:
//             //         Console.WriteLine("Kipas tanpa baling-baling");
//             //         break;
//             //     case 5:
//             //         Console.WriteLine("Telepon tanpa baterai");
//             //         break;
//             //     case 6:
//             //         Console.WriteLine("Keluar dari vending machine");
//             //         break;
//             //     default:
//             //         Console.WriteLine("Barang tidak tersedia! Silahkan pilih lagi");
//             //         break;
//             // }

//             // Using If-then-else
//             // Console.WriteLine("Pilih barang kamu 1-6 : ");
//             // int day = Convert.ToInt32(Console.ReadLine());
//             // if (day == 1){
//             //     Console.WriteLine("Pena tanpa tinta");
//             // }
//             // else if (day ==2){
//             //     Console.WriteLine("Kursi tanpa dudukan");
//             // }
//             // else if (day == 3)
//             // {
//             //     Console.WriteLine("Jam tanpa jarum");
//             // }
//             // else if (day == 4)
//             // {
//             //     Console.WriteLine("Kipas tanpa baling-baling");
//             // }
//             // else if (day == 5)
//             // {
//             //     Console.WriteLine("Telepon tanpa baterai");
//             // }
//             // else if (day == 6)
//             // {
//             //     Console.WriteLine("Keluar dari vending machine");
//             // }
//             // else
//             // {
//             //     Console.WriteLine("Barang tidak tersedia! silahkan pilih lagi");
//             // }
//         }
//     }
// }
// while (true)
// {
//     Console.WriteLine("Enter the triangle height : ");
//     string? input = Console.ReadLine();
//     if (int.TryParse(input, out int n) && n > 0)
//     {
//         for (int i = n; i > 0; i--)
//         {
//             for (int j = 0; j <= n - i; j++)
//             {
//                 Console.Write("*");
//             }
//             Console.WriteLine();
//             Thread.Sleep(500);
//         }
//         break;
//     }
//     else
//     {
//         Console.WriteLine("Invalid input, please enter a real number.");
//     }
// }
// Define correct username and password for authentication