using System;

namespace MyApplication{

    class Program2{
        static void Main(string[] args)
        {   
            Console.Write("Berapa Nilai Kamu: ");
            int nilai = Convert.ToInt32(Console.ReadLine());
            if (nilai >= 85){
                Console.WriteLine("A");
            }
            else if(nilai > 85){
                Console.WriteLine("B");
            }
            else if(nilai > 83){
                Console.WriteLine("C");
            }
            else if(nilai > 59){
                Console.WriteLine("D");
            }
            else {
                Console.WriteLine("E");
            }
        }
    }
}