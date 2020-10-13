using System;
using System.Threading;

namespace List_of_Storage_Media
{
    class Main_Menu : Graphics
    {
        private Menu Item;

        public Main_Menu()
        {
            Console.Title = "List of Storages";
            Console.WindowHeight = 40;
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.DarkGray;
            Back_to_Menu();
        }

        public void Back_to_Menu()
        {
            Print_Main();
            Item = Menu.Add_DVD;
            ChangeTextString(Item, ConsoleColor.DarkRed);
        }

        public Menu GetItem()
        {
            ChangeTextString(Item, ConsoleColor.Green);
            Thread.Sleep(250);
            Console.Clear();
            return Item;
        }

        public void Back()
        {
            ChangeTextString(Item, Console.ForegroundColor);
            ChangeTextString(Item = Item > Menu.Add_DVD ? Item -= Menu.Next : Menu.Load_JSON, ConsoleColor.DarkRed);
        }

        public void Next()
        {
            ChangeTextString(Item, Console.ForegroundColor);
            ChangeTextString(Item = Item < Menu.Load_JSON ? Item += (byte)Menu.Next : Menu.Add_DVD, ConsoleColor.DarkRed);
        }

        private void ChangeTextString(Menu position, ConsoleColor C)
        {
            Console.SetCursorPosition(1, (int)position + 1);
            Console.ForegroundColor = C;
            switch (position)
            {
                case Menu.Add_DVD:
                    Console.Write("\t\t|     Add DVD     |");
                    break;
                case Menu.Add_HDD:
                    Console.Write("\t\t|     Add HDD     |");
                    break;
                case Menu.Add_Flash:
                    Console.Write("\t\t|    Add Flash    |");
                    break;
                case Menu.Remove:
                    Console.Write("\t\t|  Remove Storage |");
                    break;
                case Menu.Print:
                    Console.Write("\t\t|   View Storages |");
                    break;
                case Menu.Print_XML:
                    Console.Write("\t\t|    Print XML    |");
                    break;
                case Menu.Print_File:
                    Console.Write("\t\t|    Print File   |");
                    break;
                case Menu.Search:
                    Console.Write("\t\t|  Search Storage |");
                    break;
                case Menu.Edit:
                    Console.Write("\t\t|   Edit Storage  |");
                    break;
                case Menu.Save_XML:
                    Console.Write("\t\t|     Save XML    |");
                    break;
                case Menu.Save_JSON:
                    Console.Write("\t\t|    Save JSON    |");
                    break;
                case Menu.Save_Binary:
                    Console.Write("\t\t|   Save Binary   |");
                    break;
                case Menu.Load_XML:
                    Console.Write("\t\t|     Load XML    |");
                    break;
                case Menu.Load_Binary:
                    Console.Write("\t\t|   Load Binary   |");
                    break;
                case Menu.Load_JSON:
                    Console.Write("\t\t|    Load JSON    |");
                    break;
            }
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
