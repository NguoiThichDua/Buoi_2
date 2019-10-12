using System;

namespace Bai_1
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            PTB2 pTB2 = new PTB2();

            Console.Write("Nhap a = ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Nhap b = ");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.Write("Nhap c = ");
            double c = Convert.ToDouble(Console.ReadLine());

            pTB2.TinhNghiem(a, b, c);

            Console.ReadKey();
        }
    }
}
