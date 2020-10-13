using System;

namespace List_of_Storage_Media
{
    class Client
    {
        static void Main()
        {
            PriceList Devices = new PriceList();
            Main_Menu Display = new Main_Menu();
            ConsoleKeyInfo Input;
            do
            {
                Input = Console.ReadKey(true);
                switch (Input.Key)
                {
                    case ConsoleKey.UpArrow:
                        Display.Back();
                        break;
                    case ConsoleKey.DownArrow:
                        Display.Next();
                        break;
                    case ConsoleKey.Enter:
                        Select(Display.GetItem(), Devices);
                        Display.Back_to_Menu();
                        break;
                }
            } while (Input.Key != ConsoleKey.Escape);
        }

        static void Select(Menu item, PriceList Devices)
        {
            switch (item)
            {
                case Menu.Add_DVD:
                    Devices.Add(new DVD());
                    break;
                case Menu.Add_HDD:
                    Devices.Add(new HDD());
                    break;
                case Menu.Add_Flash:
                    Devices.Add(new Flash());
                    break;
                case Menu.Edit:
                    Console.SetCursorPosition(0, 4);
                    Devices.Print(new ConsoleLog());
                    Devices.Edit();
                    break;
                case Menu.Print:
                    Devices.Print(new ConsoleLog());
                    Devices.Press_Back();
                    break;
                case Menu.Print_XML:
                    Devices.Print(new XMLLog());
                    break;
                case Menu.Print_File:
                    Devices.Print(new FileLog());
                    break;
                case Menu.Remove:
                    Console.SetCursorPosition(0, 4);
                    Devices.Print(new ConsoleLog());
                    Devices.Remove();
                    break;
                case Menu.Save_XML:
                    Devices.Save(new XMLSerialize());
                    break;
                case Menu.Save_Binary:
                    Devices.Save(new BinarySerialize());
                    break;
                case Menu.Save_JSON:
                    Devices.Save(new JSONSerialize());
                    break;
                case Menu.Search:
                    Console.SetCursorPosition(0, 4);
                    Devices.Print(new ConsoleLog());
                    Devices.Search();
                    Devices.Press_Back();
                    break;
                case Menu.Load_XML:
                    Devices.Load(new XMLSerialize());
                    break;
                case Menu.Load_Binary:
                    Devices.Load(new BinarySerialize());
                    break;
                case Menu.Load_JSON:
                    Devices.Load(new JSONSerialize());
                    break;
            }
        }
    }
}
