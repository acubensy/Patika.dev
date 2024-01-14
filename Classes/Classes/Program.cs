using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class Program
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

            Console.WriteLine("*****Çalışan 1 ******");
            Calisan calisan1 = new Calisan("Ayşe", "Yalçınkaya", 1245678, "İK");
            calisan1.CalisanBilgileri();

            Console.WriteLine("*****Çalışan 2 ******");
            Calisan calisan2 = new Calisan();
            calisan2.Ad = "Hasan";
            calisan2.Soyad = "Yılmaz";
            calisan2.No = 123456;
            calisan2.Departman = "Fen İşleri";
            calisan2.CalisanBilgileri();

            Console.WriteLine("*****Çalışan 3 ******");
            Calisan calisan3 = new Calisan("Ayşe" , "Yalçınkaya");
            calisan3.CalisanBilgileri();
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
            public Calisan() { } //Constructor 2 , Overloaded

            public Calisan(string ad, string soyad) // Constructor 3 , Overloaded
            { 
                this.Ad= ad;
                this.Soyad= soyad;
            } 
            
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
