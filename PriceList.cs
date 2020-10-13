using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace List_of_Storage_Media
{
    //[Serializable]
    //[DataContract]
    class PriceList
    {
        //[DataMember]
        private List<Storage> roster;

        private Graphics Layout;

        public PriceList()
        {
            roster = new List<Storage>();
            Layout = new Graphics();
        }

        public void Add(Storage device)
        {
            Layout.Add_Form();
            try
            {
                Console.SetCursorPosition(18, 1);
                device.Name_Company = Console.ReadLine();
                Console.SetCursorPosition(10, 2);
                device.Name = Console.ReadLine();
                Console.SetCursorPosition(11, 3);
                device.Speed = Convert.ToInt32(Console.ReadLine());
                Console.SetCursorPosition(14, 4);
                device.Capacity = Convert.ToDouble(Console.ReadLine());
                Console.SetCursorPosition(11, 5);
                device.Model = Console.ReadLine();
                Console.SetCursorPosition(11, 6);
                device.Count = Convert.ToInt32(Console.ReadLine());
                roster.Add(device);
            }
            catch (Exception ex)
            {
                Console.Write(ex.Message);
            }
        }

        public void Remove()
        {
            if (roster.Count < 1)
                return;
            Console.SetCursorPosition(0, 0);
            Layout.Remove_Form();
            Console.SetCursorPosition(41, 1);
            string check = Console.ReadLine();

            foreach (var device in roster)
                if (device.Name == check || device.Model == check)
                {
                    roster.Remove(device);
                    break;
                }
        }

        public void Print(ILog p)
        {
            if (roster.Count < 1)
                return;
            try
            {
                foreach (var device in roster)
                    device.Print(p);
            }
            catch
            {
                return;
            }
        }

        public void Edit()
        {
            if (roster.Count < 1)
                return;
            Console.SetCursorPosition(0, 0);
            Layout.Edit_Form();
            Console.SetCursorPosition(41, 1);
            string check = Console.ReadLine();
            foreach (var storage in roster)
                if (/*storage.Name == check || storage.Name_Company == check*/storage.Model == check)
                {
                    Storage hard;
                    if (storage.GetType().ToString() == "List_of_Storage_Media.HDD")
                        hard = new HDD();
                    else if (storage.GetType().ToString() == "List_of_Storage_Media.Flash")
                        hard = new Flash();
                    else
                        hard = new DVD();
                    roster.Remove(storage);
                    Add(hard);
                    break;
                }
        }

        public void Save(ISerialize obj)
        {
            if (roster.Count < 1)
                return;
            try
            {
                obj.Save(roster);
            }
            catch (Exception ex)
            {
                Console.Write(ex.Message);
            }
        }

        public void Load(ISerialize obj)
        {
            try
            {
                roster = obj.Load();
            }
            catch
            {
                return;
            }
        }

        public void Search()
        {
            if (roster.Count < 1)
                return;
            Console.SetCursorPosition(0, 0);
            Layout.Search_Form();
            Console.SetCursorPosition(41, 1);
            string check = Console.ReadLine();
            foreach (var storage in roster)
                if (check == storage.Model || check == storage.Name)
                {
                    Console.Clear();
                    Console.WriteLine("______________________________");
                    Console.WriteLine("---| Name - " + storage.Name);
                    Console.WriteLine("---| Name of company - " + storage.Name_Company);
                    Console.WriteLine("---| Capacity - " + storage.Capacity);
                    Console.WriteLine("---| Count - " + storage.Count);
                    Console.WriteLine("---| Model - " + storage.Model);
                    Console.WriteLine("---| Speed - " + storage.Speed);
                }
        }

        public void Press_Back()
        {
            if (roster.Count < 1)
                return;
            //Console.SetCursorPosition(0, 0);
            Console.Write("\nPress \"Esc\" or \"Enter\"");
            do
            {
                ConsoleKeyInfo Input = Console.ReadKey(true);
                if (Input.Key == ConsoleKey.Escape || Input.Key == ConsoleKey.Enter || Input.Key == ConsoleKey.Spacebar)
                    break;
            } while (true);
        }
    }
}
