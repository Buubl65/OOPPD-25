namespace Task4
{
    public class Program
    {
        public static void Main()
        {
            double a = 1f;
            double b = 2f;
            double c = 5f;
            double result = GetPerimeter(a, b, c);
        }

        public static bool IsValidTriangle(double a, double b, double c)
        {
            return a > 0 && b > 0 && c > 0 && a + b > c && a + c > b && b + c > a;
        }

        public static double GetPerimeter(double a, double b, double c)
        {
            if (IsValidTriangle(a, b, c)) { return a + b + c; }
            else { throw new ArgumentException("Помилка."); }
        }

        public static double GetArea(double a, double b, double c)
        {
            if (IsValidTriangle(a, b, c))
            {
                double per = 0;
                per = (a + b + c) / 2;

                return Math.Sqrt(per * (per - a) * (per - b) * (per - c));
            }
            else { throw new ArgumentException("Помилка"); }
        }

        public static string GetTriangleType(double a, double b, double c)
        {
            if (a == b && b == c) { return "рівносторонній"; }
            else if (a == b || b == c || a == c) { return "рівнобедрений"; }
            else if (c * c == a * a + b * b ||
                     a * a == b * b + c * c ||
                     b * b == a * a + c * c)
            {
                return "прямокутний";
            }
            else if (a != b && b != c && a != c)
            {
                return "довільний";
            }
            return "Трикутника не існує";
        }
    }
}