using System;
using System.Collections;

namespace Bai_2
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int soLuongHangNhap;

            int maSo;
            string tenHang;
            double gia;
            int soLuong;

            Console.Write("So hang hoa muon them: ");
            soLuongHangNhap = Convert.ToInt32(Console.ReadLine());

            ArrayList arrHangHoa = new ArrayList();

            for (int i = 0; i < soLuongHangNhap; i++)
            {
                Console.Write("Nhap ma hang: ");
                maSo = Convert.ToInt32(Console.ReadLine());
                Console.Write("Nhap ten hang: ");
                tenHang = Console.ReadLine();
                Console.Write("Nhap gia hang: ");
                gia = Convert.ToDouble(Console.ReadLine());
                Console.Write("Nhap so luong hang: ");
                soLuong = Convert.ToInt32(Console.ReadLine());

                arrHangHoa.Add(new HangHoa(maSo, tenHang, gia, soLuong));
            }

            Console.WriteLine("Hang hoa ban vua nhap la: ");

            foreach (HangHoa hangHoa in arrHangHoa)
            {
                Console.WriteLine(hangHoa);
            }

            Console.ReadKey();
        }
    }
}
