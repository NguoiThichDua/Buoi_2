using System;
namespace Bai_1
{
    public class PTB2
    {
        public double x1, x2;

        public void TinhNghiem(double a, double b, double c)
        {
            double delta = b * b - 4 * a * c;

            if (delta < 0)
            {
                Console.WriteLine("Phuong trinh vo nghiem");
            }
            else
            {
                if (delta == 0)
                {
                    this.x1 = this.x2 = -b / (2 * a);
                    Console.WriteLine("Phuong trinh co nghiem kep: x = " + x1);
                }
                else
                {
                    this.x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                    this.x2 = (-b - Math.Sqrt(delta)) / (2 * a);
                    Console.WriteLine("Phuong trinh co 2 nghiem phan biet:\nx1 = {0} \nx2 = {1} ", x1, x2);
                }
            }
        }
    }
}
