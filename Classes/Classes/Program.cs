using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Söz dizimi
            // class sinifAdi
            //{
            //[Erişim belirleyici] [Veri tipi] OzellikAdi;
            //[Erişim belirleyici] [Geri dönüş tipi] MetotAdi([Parametre Listesi])
            //{
            //Metot komutları
            //}
            //}

            //Erişim belirleyiciler
            // * Public
            // * Private
            // * Internal
            // * Protected
            Console.WriteLine("*****Çalışan ******");
            Calisan calisan1 = new Calisan("Ayşe", "Yalçınkaya", 1245678, "İK");
            calisan1.CalisanBilgileri();

            Console.WriteLine("*****Çalışan ******");
            Calisan calisan2 = new Calisan();
            calisan1.Ad = "Hasan";
            calisan1.Soyad = "Yılmaz";
            calisan1.No = 123456;
            calisan1.Departman = "Fen İşleri";
            calisan1.CalisanBilgileri();

        }

        class Calisan
        {
            public string Ad;
            public string Soyad;
            public int No;
            public string Departman;

            public Calisan(string ad, string soyad, int no, string departman) // Constructor 
            {
                this.Ad = ad;
                this.Soyad = soyad;
                this.No = no;
                this.Departman = departman;
            }
            public Calisan() { } //Constructor 2

            public Calisan(string ad, string soyad) { } // Constructor 3
            public void CalisanBilgileri() //method
            {
                Console.WriteLine("Çalışanın Adı: {0}", Ad);
                Console.WriteLine("Çalışanın Soyadı: {0}", Soyad);
                Console.WriteLine("Çalışanın Numarası: {0}", No);
                Console.WriteLine("Çalışanın Departmanı: {0}", Departman);
            }
        }
    }
    
}
