using System;
using System.Text;

namespace EventAndDeleget
{
    internal class Program
    {
        public static void Main()
        {
            Console.OutputEncoding=Encoding.UTF8;
            Console.WriteLine("Tìm nghiệm phương trình bậc hai");
            float a, b, c;
            Console.WriteLine("Nhập a: ");
            a = float.Parse(Console.ReadLine());
            Console.WriteLine("Nhập a: ");
            b = float.Parse(Console.ReadLine());
            Console.WriteLine("Nhập a: ");
            c = float.Parse(Console.ReadLine());
            var delta = b * b - 4 * a * c;
            if (delta > 0)
            {
                Console.WriteLine("Phương trình có 2 nghiệm: ");
                Console.WriteLine("x1={0}",(-b-Math.Sqrt(delta)) / 2 * a);
                Console.WriteLine("x2={0}",(-b+Math.Sqrt(delta)) / 2 * a);
            }else if (delta==0)
            {
                Console.WriteLine("Phương trình có nghiệm kép");
            }
            else if (delta < 0)
            {
                Console.WriteLine("Phương trình vô nghiệm");
            }
        }
    }
}