using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateArea
{
    public class Program
    {
        static void Main(string[] args)
        {
            bool devam = true;

            while (devam)
            {
                {
                    Console.WriteLine("Lütfen bir geometrik şekil seçin (Daire, Dikdörtgen, Kare, Üçgen):");
                    string shapeType = Console.ReadLine().ToLower();

                    IShape shape = null;
                    try
                    {
                        switch (shapeType)
                        {
                            case "daire":
                                Console.WriteLine("Yarıçapı girin:");
                                double radius = Convert.ToDouble(Console.ReadLine());
                                shape = new Circle(radius);
                                break;
                            case "dikdörtgen":
                                Console.WriteLine("Uzunluğu girin:");
                                double length = Convert.ToDouble(Console.ReadLine());
                                Console.WriteLine("Genişliği girin:");
                                double width = Convert.ToDouble(Console.ReadLine());
                                shape = new Rectangle(length, width);
                                break;
                            case "kare":
                                Console.WriteLine("Kenar uzunluğunu girin:");
                                double side = Convert.ToDouble(Console.ReadLine());
                                shape = new Square(side);
                                break;
                            case "üçgen":
                                Console.WriteLine("Taban uzunluğunu girin:");
                                double baseLength = Convert.ToDouble(Console.ReadLine());
                                Console.WriteLine("Yüksekliği girin:");
                                double height = Convert.ToDouble(Console.ReadLine());
                                shape = new Triangle(baseLength, height);
                                break;
                            default:
                                Console.WriteLine("Geçersiz şekil!");
                                continue;
                        }

                        Console.WriteLine("Hesaplanacak boyutu seçin (Alan, Çevre):");
                        string dimension = Console.ReadLine().ToLower();

                        switch (dimension)
                        {
                            case "alan":
                                Console.WriteLine("Alan: " + shape.CalculateArea());
                                break;
                            case "çevre":
                                if (shape is Triangle)
                                {
                                    Console.WriteLine("Üçgen için çevre hesaplaması yapılamıyor.");
                                }
                                else
                                {
                                    Console.WriteLine("Çevre: " + shape.CalculatePerimeter());
                                }
                                break;
                            default:
                                Console.WriteLine("Geçersiz boyut!");
                                break;
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Hata: " + ex.Message);
                    }

                    Console.WriteLine("Başka bir işlem yapmak ister misiniz? (evet/hayır):");
                    string userResponse = Console.ReadLine().ToLower();
                    devam = userResponse == "evet";
                }
            }
        }
    }
}