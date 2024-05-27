using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PZ_19
{
    internal class Triangle : GeometricFigure
    {
        public override double CalculateArea(params double[] number)
        {
            if (number.Length != 3)
                throw new ArgumentException("Для треугольника нужно три параметра: основание и высота");
            return 0.5 * number[0] * number[1];
        }

        public override double CalculatePerimeter(params double[] number)
        {
            if (number.Length != 3)
                throw new ArgumentException("Для треугольника нужно три параметра: сторона 1, сторона 2, сторона 3");
            return number[0] + number[1] + number[2];
        }
    }
}
}
