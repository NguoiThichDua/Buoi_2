using System;
namespace Bai_3
{
    public class SinhVien
    {
        public string maSinhVien;
        public string ho;
        public string ten;
        public double diemTrungBinh;

        public string MaSinhVien {
            get { return maSinhVien; }
            set { maSinhVien = value; }
        }

        public string Ho
        {
            get { return ho; }
            set { ho = value; }
        }
        public string Ten
        {
            get { return ten; }
            set { ten = value; }
        }

        public double DiemTrungBinh
        {
            get { return diemTrungBinh; }
            set { diemTrungBinh = value; }
        }

        // Contructor
        public SinhVien()
        {
        }

        public SinhVien(string MaSinhVien, string Ho, string Ten, double DiemTrungBinh)
        {
            this.maSinhVien = MaSinhVien;
            this.ho = Ho;
            this.ten = Ten;
            this.diemTrungBinh = DiemTrungBinh;
        }

        public override string ToString()
        {
            return "Ma sinh vien: " + this.maSinhVien + " | " + "Ten sinh vien: " + this.ten + " | " + "Diem sinh vien: " + this.diemTrungBinh;
        }
    }
}
