namespace MyApplication
{
    class Program
    {
        static void Main()
        {
            // Meminta input berat badan (kg) dan tinggi badan (cm)
            Console.Write("Masukkan berat badan (kg): ");
            double beratBadan = Convert.ToDouble(Console.ReadLine());

            Console.Write("Masukkan tinggi badan (cm): ");
            double tinggiBadan = Convert.ToDouble(Console.ReadLine());

            // Hitung IMT
            double tinggiMeter = tinggiBadan / 100; // Ubah tinggi badan dari cm ke meter
            double imt = beratBadan / (tinggiMeter * tinggiMeter);

            // Output IMT dan kategori
            Console.WriteLine("Indeks Massa Tubuh (IMT) Anda adalah: " + imt.ToString("F2"));

            // Menentukan kategori berat badan berdasarkan IMT
            if (imt < 18.5)
            {
                Console.WriteLine("Berat badan Anda di bawah normal.");
            }
            else if (imt >= 18.5 && imt <= 24.9)
            {
                Console.WriteLine("Berat badan Anda normal.");
            }
            else if (imt >= 25.0 && imt <= 29.9)
            {
                Console.WriteLine("Berat badan Anda berlebih.");
            }
            else
            {
                Console.WriteLine("Anda termasuk obesitas, konsultasikan ke dokter.");
            }
        }
    }

}