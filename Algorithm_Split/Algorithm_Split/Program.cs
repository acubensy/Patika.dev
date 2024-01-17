using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm_Split
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lütfen bir string ve bir sayı girin (örnek: Algoritma,3):");
            string input = Console.ReadLine();

            try
            {
                string[] parts = input.Split(',');
                string text = parts[0];
                int index = Convert.ToInt32(parts[1]);

                if (index < 0 || index >= text.Length)
                {
                    Console.WriteLine("Index, metnin uzunluğu dışında.");
                }
                else
                {
                    string result = text.Remove(index, 1);
                    Console.WriteLine("Sonuç: " + result);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Hata: " + ex.Message);
            }
            Console.Read();
        }
    }
}
