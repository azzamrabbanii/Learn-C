
string correctUsername = "azzam";
string correctPassword = "azzam321";

while (true)
{
    Console.WriteLine("Masukkan username anda: ");
    string username = Console.ReadLine();

    Console.WriteLine("Masukkan password anda: ");
    string password = Console.ReadLine();  

    if (username == correctUsername && password == correctPassword)
    {
        Console.WriteLine("Login berhasil! Selamat datang, " + username + "!");
        break;  
    }
    else
    {
        Console.WriteLine("Username atau password salah. Silakan coba lagi.");
    }
}
