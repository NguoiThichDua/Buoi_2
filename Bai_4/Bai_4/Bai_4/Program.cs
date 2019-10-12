using System;
using System.Collections.Generic;

namespace Bai_4
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            display();

            Console.ReadKey();
        }

        private static void display()
        {
            Boolean check = true;
            int choice;

            List<CD> listCD = new List<CD>();

            Console.Write("MENU\n--------------------------\n");

            while (check)
            {
                Console.WriteLine("\n1.Add CD\n2.Search CD\n3.Display catalog\n4.Exit");

                Console.Write("Your Choice: ");
                choice = Convert.ToInt32(Console.ReadLine());


                switch (choice)
                {
                    case 1:
                        if (listCD.Count > 1000)
                        {
                            check = false;
                        }
                        else
                        {
                            listCD = AddCD.addCD(listCD);
                        }
                        break;
                    case 2:
                        Console.WriteLine("\nNhap name can tim: ");
                        string name = Console.ReadLine();

                        CD cd = SearchCD.searchCD(name, listCD);
                        Console.Write("\n-------------THONG TIN TIM DUOC-------------");
                        Console.WriteLine("\nName " + cd.CDNAME);
                        Console.WriteLine("Type " + cd.CDTYPE);
                        Console.WriteLine("Price " + cd.CDPRICE);
                        Console.WriteLine("--------------------------------------------");

                        break;
                    case 3:
                        DisplayCD.displayCatalog(listCD);
                        break;
                    default:
                        check = false;
                        break;
                }
            }
        }
    }
}
