using System;

namespace perintah_masukan
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Masukan Nama Anda =\t");
            String nama = Console.ReadLine();
            Console.WriteLine("nama anda adalah {0}", nama);
            Console.Read();
        }
    }
}

