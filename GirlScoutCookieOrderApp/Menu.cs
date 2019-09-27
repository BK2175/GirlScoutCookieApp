using System;
using System.Collections.Generic;
using System.Text;

namespace GirlScoutCookieOrderApp
{
    static class Menu
    {
        //public Menu()
        //{

        //}

        public static void MenuMain()
        {
            Console.WriteLine("MAIN MENU");
            Console.WriteLine(" ");
            Console.WriteLine("To place a cookie order: Press 1");
            Console.WriteLine("For product reporting: Press 2");
            Console.WriteLine("To exit: Press 3");
            string userSelectionMain = Console.ReadLine();
            //return userSelectionMain;
            if (userSelectionMain == "1")
            {
                Console.Clear();
                MenuOrder();
            }

            else if (userSelectionMain == "2")
            {
                Console.Clear();
                Menu.MenuReporting();
            }

            else if (userSelectionMain == "3")
            {
                Environment.Exit(0);
            }


        }







        public static void MenuOrder()
        {
            Console.WriteLine("Girl Scout Cookie Order Menu");
            Console.WriteLine(" ");
            Console.WriteLine("Samoas: Press 1");
            Console.WriteLine("For Thin Mints: Press 2");
            Console.WriteLine("For Tagalongs: Press 3");
            Console.WriteLine("For Lemonades: Press 4");
            Console.WriteLine("If finished , to exit : Press 5");
            Console.WriteLine("To return to main menu: Press 6");
            string userSelectionOrder = Console.ReadLine();

            if (userSelectionOrder == "1")
            {

            }

            else if (userSelectionOrder == "2")
            {

            }
            
            else if (userSelectionOrder == "3")
            {

            }

            else if (userSelectionOrder == "4")
            {

            }

            else if (userSelectionOrder == "5")
            {
                Environment.Exit(0);
            }

            else if (userSelectionOrder == "6")
            {
                MenuMain();
            }



        }



        public static string MenuReporting()
        {
            Console.WriteLine("Girl Scout Cookie Reports Menu");
            Console.WriteLine(" ");
            Console.WriteLine("To print a list of all cookies: Press 1");
            Console.WriteLine("To find total boxes ordered: Press 2");
            Console.WriteLine("To remove a variety from the list: Press 3");
            Console.WriteLine("To return to main menu: Press 4");
            string userSelectionReport = Console.ReadLine();
            return userSelectionReport;
        }
    }
}

