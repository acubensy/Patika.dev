using System;

namespace Array_methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Sort
            int[] sayiDizisi = { 92, 43, 4, 16, 72, 3, 11, 37 };
            Console.WriteLine("***Sirasiz Dizi***");
            foreach (var sayi in sayiDizisi)
            {
                Console.WriteLine(sayi);
            }
            Console.WriteLine("***Sirali Dizi***");
            Array.Sort(sayiDizisi);
            foreach (var sayi in sayiDizisi)
            {
                Console.WriteLine(sayi);
            }
            //Clear - Sıfırlama
            Console.WriteLine("***Array Clear***");
            Array.Clear(sayiDizisi, 2, 2);
            foreach (var sayi in sayiDizisi)
            {
                Console.WriteLine(sayi);
            }

            // Reverse
            Console.WriteLine("***Array Reverse***");
            Array.Reverse(sayiDizisi);
            foreach (var sayi in sayiDizisi)
            {
                Console.WriteLine(sayi);
            }

            //IndexOf 
            Console.WriteLine("***Array IndexOf***");
            Console.WriteLine(Array.IndexOf(sayiDizisi, 23));

            //Resize 
            Console.WriteLine("***Array Resize***");
            Array.Resize<int>(ref sayiDizisi, 9);
            sayiDizisi[8] = 99;
            foreach (var sayi in sayiDizisi)
            {
                Console.WriteLine(sayi);
            }
        }
    }
}
