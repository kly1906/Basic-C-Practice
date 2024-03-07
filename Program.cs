using System.Net;
using System.Text;

namespace subprogram_practice
{
    internal class Program
    {
        public static int countMonths(float a, float b , int month)
        {
            while (a <= b)
            {
                a += (b * 0.05f);
                month++;
            }
            return month;
        }
        static void Main(string[] args)
        {
            float a, b;
            int count_months = 0;
            while (true)
            {
                Console.Write("Enter the principal amount: ");
                a = float.Parse(Console.ReadLine());
                if (a > 0)
                    break;
            }
            while (true)
            {
                Console.Write("Enter the desired amount: ");
                b = float.Parse(Console.ReadLine());
                if (b > a)
                    break;
            }

            int month = countMonths(a, b, count_months);
            int year = month / 12;

            Console.WriteLine("Time to reach the desired amount: {0} year, {1} month", year, month - year * 12);
        }
    }
}