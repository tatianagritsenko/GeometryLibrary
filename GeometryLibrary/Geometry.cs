namespace GeometryLibrary
{
    public static class Geometry
    {
        public static double CalculateCircleArea(double radius)
        {
            if (radius <= 0)
            {
                throw new ArgumentException("Радиус должен быть положительным числом.");
            }

            return Math.PI * radius * radius;
        }

        public static double CalculateTriangleArea(double sideA, double sideB, double sideC)
        {
            if (sideA <= 0 || sideB <= 0 || sideC <= 0)
            {
                throw new ArgumentException("Стороны треугольника должны быть положительными числами.");
            }

            double p = (sideA + sideB + sideC) / 2;
            return Math.Sqrt(p * (p - sideA) * (p - sideB) * (p - sideC));
        }

        public static bool IsRightTriangle(double sideA, double sideB, double sideC)
        {
            double[] sides = { sideA, sideB, sideC };
            Array.Sort(sides);

            return Math.Pow(sides[2], 2) == Math.Pow(sides[0], 2) + Math.Pow(sides[1], 2);
        }
    }
}