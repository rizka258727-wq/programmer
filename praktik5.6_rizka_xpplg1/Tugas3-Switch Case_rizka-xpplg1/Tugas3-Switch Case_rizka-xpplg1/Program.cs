using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tugas3_Switch_Case_rizka_xpplg1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Masukkan angka (1-5): ");
            int angka = int.Parse(Console.ReadLine());

            switch (angka)
            {
                case 1:
                    Console.WriteLine("Merah");
                    break;
                case 2:
                    Console.WriteLine("Biru");
                    break;
                case 3:
                    Console.WriteLine("Hijau");
                    break;
                case 4:
                    Console.WriteLine("Kuning");
                    break;
                case 5:
                    Console.WriteLine("Hitam");
                    break;
                default:
                    Console.WriteLine("Angka tidak valid");
                    break;
            }
        }
    }
}
