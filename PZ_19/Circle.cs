using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PZ_19
{
    internal class Circle : GeometricFigure
    {
        public override double CalculateArea(params double[] number)
        {
            if (number.Length != 1)
                throw new ArgumentException("Для окружности нужен радиус");
            return Math.PI * number[0] * number[0];
        }

        public override double CalculatePerimeter(params double[] number)
        {
            if (number.Length != 1)
                throw new ArgumentException("Для окружности нужен радиус");
            return 2 * Math.PI * number[0];
        }
    }
}
