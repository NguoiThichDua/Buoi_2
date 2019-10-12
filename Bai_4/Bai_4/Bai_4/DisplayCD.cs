using System;
using System.Collections.Generic;

namespace Bai_4
{
    public class DisplayCD
    {
        public static void displayCatalog(List<CD> list)
        {
            foreach (CD temp in list)
            {
                Console.WriteLine("\n----------DANH SACH CD-----------");
                Console.Write(temp.ToString() + "\n");
                Console.WriteLine("-------------------------------------");
            }
        }
        public DisplayCD()
        {
        }


    }
}
