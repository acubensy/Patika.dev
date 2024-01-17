using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateArea
{
    public class Triangle:IShape
    {
        public double BaseLength { get; set; } 
        public double Height { get; set; }

        public Triangle(double baseLength, double height)
        {
            BaseLength = baseLength;
            Height = height;
        }

        public double CalculateArea()
        {
            return BaseLength * Height / 2;
        }

        public double CalculatePerimeter()
        {
            throw new NotImplementedException("Üçgenin çevresi için kenar uzunlukları gereklidir.");
        }
    }
}
