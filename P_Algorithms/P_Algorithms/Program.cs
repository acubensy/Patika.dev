using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P_Algorithms
{
    public class Program
    {
        static void Main(string[] args)
        {
            bool devam = true;

            while (devam)
            {
                Console.WriteLine("Lütfen yapmak istediğiniz işlemi seçin:");
                Console.WriteLine("1. Çift Sayıları Yazdır");
                Console.WriteLine("2. Belirli Kritere Göre Sayıları Yazdır");
                Console.WriteLine("3. Kelimeleri Ters Sırayla Yazdır");
                Console.WriteLine("4. Cümledeki Kelime ve Harf Sayısını Yazdır");
                Console.WriteLine("5. Çıkış");
                Console.WriteLine("Seçiminizi yapın (1-5): ");
                int secim = Convert.ToInt32(Console.ReadLine());

                switch (secim)
                {
                    case 1:
                        CiftSayilariYazdir();
                        break;
                    case 2:
                        KritereGoreSayilariYazdir();
                        break;
                    case 3:
                        KelimeleriTersYazdir();
                        break;
                    case 4:
                        CumleAnaliziYap();
                        break;
                    case 5:
                        devam = false;
                        break;
                    default:
                        Console.WriteLine("Geçersiz seçim.");
                        break;
                }
            }
        }

        static void CiftSayilariYazdir()
        {
            Console.Write("Pozitif bir sayı girin (n): ");
            int n = Convert.ToInt32(Console.ReadLine());

            if (n <= 0)
            {
                Console.WriteLine("Lütfen pozitif bir sayı giriniz.");
                return;
            }

            Console.WriteLine($"{n} adet pozitif sayı girin: ");

            for (int i = 0; i < n; i++)
            {
                int sayi = Convert.ToInt32(Console.ReadLine());

                if (sayi % 2 == 0)
                {
                    Console.WriteLine("Çift Sayı: " + sayi);
                }
            }
            Console.WriteLine("");

        }

        static void KritereGoreSayilariYazdir()
        {
            Console.WriteLine("İki pozitif sayı girin (n ve m): ");
            Console.Write("1. Sayı: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.Write("2. Sayı: ");
            int m = Convert.ToInt32(Console.ReadLine());

            if (n <= 0 || m <= 0)
            {
                Console.WriteLine("Lütfen pozitif sayılar giriniz.");
                return;
            }

            Console.WriteLine($"{n} adet pozitif sayı girin: ");

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"{i + 1}. sayı: ");
                int sayi = Convert.ToInt32(Console.ReadLine());

                if (sayi % m == 0)
                {
                    Console.WriteLine($"{sayi} sayısı {m} sayısına tam bölünür.");
                }
                else
                {
                    Console.WriteLine($"{sayi} sayısı {m} sayısına tam bölünemez");
                }
            }

            Console.WriteLine("");
        }
    

        static void KelimeleriTersYazdir()
        {
            Console.WriteLine("Pozitif bir sayı girin (n): ");
            int n = Convert.ToInt32(Console.ReadLine());
            string[] kelimeler = new string[n];
            Console.WriteLine($"{n} adet kelime girin: ");

            for (int i = 0; i < n; i++)
            {
                Console.Write($"{i+1}. kelime: ");
                kelimeler[i] = Console.ReadLine();
            }

            Console.WriteLine("Girdiğiniz kelimeler: ");
            for (int i = n - 1; i >= 0; i--)
            {
                Console.WriteLine(kelimeler[i]);
            }
            Console.WriteLine("");
        }

        static void CumleAnaliziYap()
        {
            Console.WriteLine("Bir cümle yazın: ");
            string cumle = Console.ReadLine();
            string[] kelimeler = cumle.Split(' ');

            int kelimeSayisi = kelimeler.Length;
            int harfSayisi = cumle.Replace(" ", "").Length;

            Console.WriteLine($"Kelime Sayısı: {kelimeSayisi}");
            Console.WriteLine($"Harf Sayısı: {harfSayisi}");
            Console.WriteLine("");
        }

    }
}
