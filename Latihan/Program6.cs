using System;

namespace MyApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Mulai Program...");
            int i = 10;
            while(i > 0){
                Console.WriteLine(i);
                i--;
                if(i == 0){
                    break;
                }
                Thread.Sleep(500);
            }
            Console.WriteLine("Selesai Program...");
        }
    }
}