using System;
using System.Collections;

namespace Bai_3
{
    public class SortSinhVien : IComparer
    {
        public int Compare(object x, object y)
        {
            SinhVien p1 = x as SinhVien;
            SinhVien p2 = y as SinhVien;

            if (p1 == null || p2 == null)
            {
                throw new InvalidOperationException();
            }
            else
            {
                /*
                 * Khi dữ liệu đã ok thì ta thực hiện so sánh và trả về các giá trị 1 0 -1 tương ứng
                 * lớn hơn, bằng, bé hơn.
                 */
                if (p1.DiemTrungBinh < p2.DiemTrungBinh)
                {
                    return 1;
                }
                else if (p1.DiemTrungBinh == p2.DiemTrungBinh)
                {
                    return 0;
                }
                else
                {
                    return -1;
                }
            }
        }
    }
}
