using System.Diagnostics.CodeAnalysis;

namespace _1._1Uzduotis_FOR
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Iveskite skaiciu: ");
            int n = Convert.ToInt32(Console.ReadLine());

            int sum = 0;

           for (int i = 1; i <= n ; i++)
            {
                sum += i;
                Console.WriteLine(sum);
            }
        }
    }
}
