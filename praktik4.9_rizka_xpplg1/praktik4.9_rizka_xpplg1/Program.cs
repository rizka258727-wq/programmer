using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace praktik4._9_rizka_xpplg1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Masukkan umur: ");
            int umur = int.Parse(Console.ReadLine());

            if (umur < 5)
            {
            else if (umur <= 60)             }Tiket

                Console.WriteLine("Harga Tiket: Rp 50.000");
            { 
                Console.WriteLine(" Gratis.");
            }
            else if (umur <= 12)
            {
                Console.WriteLine("Harga Tiket: Rp 20.000");
            }
            else
            {
                Console.WriteLine("Harga Tiket: Rp 30.000 (Diskon Lansia)");
            }
        }
    }
}
