using System;

namespace calculator.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            float a, b;
            int pilihan;
            float hasil;

            Console.WriteLine("          CARA MEMBUAT KALKULATOR SEDERHANA C# ");
            Console.WriteLine("==================================");
            Console.WriteLine("Menu : ");
            Console.WriteLine("      1. Penjumlahan (+) ");
            Console.WriteLine("      2. Pengurangan (-) ");
            Console.WriteLine("      3. Perkalian (*) ");
            Console.WriteLine("      4. Pembagian (/) ");


            Console.WriteLine("==================================");
            Console.WriteLine("PILIH 4 MENU DI ATAS ANGKA SAJA  ");
            pilihan = int.Parse(System.Console.In.ReadLine());
            Console.WriteLine("INPUT NILAI A : ");
            a = int.Parse(System.Console.In.ReadLine());
            Console.WriteLine("INPUT NILAI B : ");
            b = int.Parse(System.Console.In.ReadLine());
            
            switch (pilihan)
            {
                case 1:
                    hasil = a + b;
                    Console.WriteLine("Hasil Penjumlahan  : " + hasil);
                    Console.WriteLine("                                 ");
                    Console.WriteLine("                 ~~~ OKSIP ~~~ ");
                    break;
                case 2:
                    hasil = a - b;
                    Console.WriteLine("Hasil Pengurangan : " + hasil);
                    Console.WriteLine("                                 ");
                    Console.WriteLine("                 ~~~ OKSIP ~~~ ");
                    break;
                case 3:
                    hasil = a * b;
                    Console.WriteLine("Hasil Perkalian : " + hasil);
                    Console.WriteLine("                                 ");
                    Console.WriteLine("                 ~~~ OKSIP ~~~ ");
                    break;
                case 4:
                    hasil = a / b;
                    Console.WriteLine("Hasil Pembagian : " + hasil);
                    Console.WriteLine("                                 ");
                    Console.WriteLine("                 ~~~ OKSIP ~~~ ");
                    break;
                default:
                    Console.WriteLine("PILIH MENU YANG ADA DIATAS!!!");
                    break;
            }
            Console.ReadLine();
        }
    }
}
