using System;
using System.Collections;

namespace Bai_3
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int soLuongNhap;

            string maSinhVien;
            string ho;
            string ten;
            double diemTrungBinh;

            Console.Write("So sinh vien muon them: ");
            soLuongNhap = Convert.ToInt32(Console.ReadLine());

            ArrayList arrSinhVien = new ArrayList();

            for (int i = 0; i < soLuongNhap; i++)
            {
                Console.Write("Nhap ma sv: ");
                maSinhVien = Console.ReadLine();
                Console.Write("Nhap ho sv: ");
                ho = Console.ReadLine();
                Console.Write("Nhap ten sv: ");
                ten = Console.ReadLine();
                Console.Write("Nhap diem trung binh: ");
                diemTrungBinh = Convert.ToInt32(Console.ReadLine());

                arrSinhVien.Add(new SinhVien(maSinhVien, ho, ten, diemTrungBinh));
            }

            Console.Write(Environment.NewLine);

            Console.WriteLine("So sinh vien vua them la: ");

            foreach (SinhVien hangHoa in arrSinhVien)
            {
                Console.WriteLine(hangHoa);
            }


            // sap xep
            arrSinhVien.Sort((System.Collections.IComparer)new SortSinhVien());
            Console.WriteLine();

            Console.WriteLine("Danh sach Sinh Vien da duoc sap xep theo diem giam dan: ");

            int stt = 0;
            foreach (SinhVien sv in arrSinhVien)
            {
                if (stt == 3)
                {
                    break;
                }
                Console.WriteLine(sv);
                stt++;
            }

            Console.ReadKey();

        }
    }
}
