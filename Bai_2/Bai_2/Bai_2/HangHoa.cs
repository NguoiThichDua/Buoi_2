using System;
namespace Bai_2
{
    public class HangHoa
    {
        public int maHang;
        public string tenHang;
        public double gia;
        public int soLuong;

        public int MaHang {
            get { return maHang; }
            set { maHang = value; }
        }
        public string TenHang
        {
            get { return tenHang; }
            set { tenHang = value; }
        }
        public double Gia
        {
            get { return gia; }
            set { gia = value; }
        }
        public int SoLuong
        {
            get { return soLuong; }
            set { soLuong = value; }
        }

        // Contructor
        public HangHoa()
        {
        }

        public HangHoa(int MaHang, string TenHang, double Gia, int SoLuong)
        {
            this.maHang = MaHang;
            this.tenHang = TenHang;
            this.gia = Gia;
            this.soLuong = SoLuong;
        }

        /// <summary>
        /// Override phương thức ToString để khi cần có thể in thông tin của object ra cho nhanh.
        /// </summary>
        /// <returns>A <see cref="T:System.String"/> that represents the current <see cref="T:Bai_2.HangHoa"/>.</returns>
        public override string ToString()
        {
            return "Ma Hang: " + this.maHang + " | " + "Ten Hang: " + this.tenHang + " | " + "Gia: " + this.gia + " | " + "So Luong: " + this.soLuong;
        }
    }
}
