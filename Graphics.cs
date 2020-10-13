using System;
using System.Threading;


namespace List_of_Storage_Media
{
    public enum Menu
    {
        Add_DVD = 1,
        Next,
        Add_HDD = 3,
        Add_Flash = 5,
        Remove = 7,
        Print = 9,
        Print_XML = 11,
        Print_File = 13,
        Search = 15,
        Edit = 17,
        Save_XML = 19,
        Save_Binary = 21,
        Save_JSON = 23,
        Load_XML = 25,
        Load_Binary = 27,
        Load_JSON = 29,
        
        //Add_HDD = 1, Add_DVD = 3, Add_Flash = 5,

        //Exit = -1,
        //Back = 27
    }

    public class Graphics
    {
        //protected Menu Item;

        //public abstract void Back();
        //public abstract void Next();
        //public abstract void ChangeTextString(Menu position, ConsoleColor C);

        protected void Print_Main()
        {
            Console.Clear();
            Console.CursorVisible = false;
            Console.Write("\n\t\t.-----------------.\n"
                        + "\t\t|     Add DVD     |\n"
                        + "\t\t:-----------------:\n"
                        + "\t\t|     Add HDD     |\n"
                        + "\t\t:-----------------:\n"
                        + "\t\t|    Add Flash    |\n"
                        + "\t\t:-----------------:\n"
                        + "\t\t|  Remove Storage |\n"
                        + "\t\t:-----------------:\n"
                        + "\t\t|   View Storages |\n"
                        + "\t\t:-----------------:\n"
                        + "\t\t|    Print XML    |\n"
                        + "\t\t:-----------------:\n"
                        + "\t\t|    Print File   |\n"
                        + "\t\t:-----------------:\n"
                        + "\t\t|  Search Storage |\n"
                        + "\t\t:-----------------:\n"
                        + "\t\t|   Edit Storage  |\n"
                        + "\t\t:-----------------:\n"
                        + "\t\t|     Save XML    |\n"
                        + "\t\t:-----------------:\n"
                        + "\t\t|   Save Binary   |\n"
                        + "\t\t|-----------------|\n"
                        + "\t\t|    Save JSON    |\n"
                        + "\t\t:-----------------:\n"
                        + "\t\t|     Load XML    |\n"
                        + "\t\t:-----------------:\n"
                        + "\t\t|   Load Binary   |\n"
                        + "\t\t|-----------------|\n"
                        + "\t\t|    Load JSON    |\n"
                        + "\t\t:-----------------:\n"
                        + "\t\t|    Esc - Exit   |\n"
                        + "\t\t`-----------------`\n");
        }


        //protected void Print_Add_Menu()
        //{
        //    Console.Clear();
        //    Console.CursorVisible = false;
        //    Console.Write(".-----------------.\n"
        //                + "|     Add HDD     |\n"
        //                + ":-----------------:\n"
        //                + "|     Add DVD     |\n"
        //                + ":-----------------:\n"
        //                + "|    Add Flash    |\n"
        //                + ":-----------------:\n"
        //                + "|   Esc - Back    |\n"
        //                + "`-----------------`\n");
        //}

        public void Add_Form()
        {
            Console.Clear();
            Console.CursorVisible = true;
            Console.Write(".-------------------------------.\n"
                        + "|  Name Company -               |\n"
                        + "|  Name -                       |\n"
                        + "|  Speed -                      |\n"
                        + "|  Capacity -                   |\n"
                        + "|  Model -                      |\n"
                        + "|  Count -                      |\n"
                        + "`-------------------------------`");
        }

        public void Input_Form()
        {
            Console.CursorVisible = true;
            Console.WriteLine("._________________________________________________________.");
            Console.WriteLine("|                                                         |");
            Console.WriteLine("\\._______________________________________________________./");
            Console.SetCursorPosition(0, 1);
        }

        public void Edit_Form()
        {
            Input_Form();
            Console.WriteLine("|Please enter model name to edit -");
        }

        public void Search_Form()
        {
            Input_Form();
            Console.WriteLine("|Please enter name or model to search -");
        }

        public void Remove_Form()
        {
            Input_Form();
            Console.WriteLine("|Please enter name or model to remove -");
        }

    }
}
