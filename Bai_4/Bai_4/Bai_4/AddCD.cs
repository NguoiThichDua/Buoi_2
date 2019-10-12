using System;
using System.Collections.Generic;

namespace Bai_4
{
    public class AddCD
    {
        public static List<CD> addCD(List<CD> list)
        {
            string name;
            string type;
            double price;


            Console.Write("\n------------NHAP THONG TIN--------------");
            Console.Write("\nNhap name = ");
            name = Console.ReadLine();

            // qlsv.Mssv = arrMssv[i];

            Console.Write("Nhap type = ");
            type = Console.ReadLine();
            //qlsv.HoTen = arrTenSV[i];

            Console.Write("Nhap price = ");
            price = Convert.ToDouble(Console.ReadLine());
            //qlsv.DiemTB = arrDTB[i];

            list.Add(new CD(name, type, price));
            return list;
        }

        public AddCD()
        {
        }

        
    }
}
