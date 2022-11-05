using System;

namespace Perulangan_Dengan_While
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("======================Belajar Perulangan Dengan While======================");
            int ngulang = 1;
            while(ngulang <= 4)
            {
                Console.WriteLine("\ngulang lagi sampai lulus " + ngulang);
                ngulang++;
            }
            Console.Read();
        }
    }
}

