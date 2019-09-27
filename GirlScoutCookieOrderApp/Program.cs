using System;

namespace GirlScoutCookieOrderApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //string userSelectionMain;
            Console.WriteLine("Welcome to the Girl Scout Cookie Portal");
            Console.WriteLine(" ");
            Console.WriteLine("Press any key to continue");
            Console.ReadLine();
            Console.Clear();
            //string mainMenuChoice = Menu.MenuMain();

            Menu.MenuMain();
            Console.ReadLine();

            //if (userSelection == "1")
            //{
            //    Menu.MenuOrder();
            //}

            //else if (userSelection == "2")
            //{
            //    Menu.MenuReporting();
            //}

            //else if (userSelection == "3")
            //{
            //    Environment.Exit(0);
            //}
        

        }
        
    }
}
