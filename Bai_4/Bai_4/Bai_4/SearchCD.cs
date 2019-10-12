using System;
using System.Collections.Generic;

namespace Bai_4
{
    public class SearchCD
    {
        public static CD searchCD(string name, List<CD> list)
        {
            foreach (CD temp in list)
            {
                if (temp.CDNAME == name)
                {
                    return temp;
                }
            }
            return null;
        }
        public SearchCD()
        {
        }
    }
}
