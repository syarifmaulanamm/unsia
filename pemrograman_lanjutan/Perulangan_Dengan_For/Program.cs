using System;

namespace Perulangan_Dengan_For
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Seluruh Point Yang Anda Kumpulkan ");
            for (int Point = 1; Point <= 10; Point++)
            {
                Console.WriteLine("Point Ke : " + Point.ToString());
            }
            Console.Read();
        }
    }
}

