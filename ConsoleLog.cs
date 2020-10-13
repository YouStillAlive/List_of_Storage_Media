using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List_of_Storage_Media
{
    class ConsoleLog : ILog
    {
        public void Print(Storage device)
        {
            Console.WriteLine("______________________________");
            Console.WriteLine("---| Name - " + device.Name);
            Console.WriteLine("---| Name of company - " + device.Name_Company);
            Console.WriteLine("---| Capacity - " + device.Capacity);
            Console.WriteLine("---| Count - " + device.Count);
            Console.WriteLine("---| Model - " + device.Model);
            Console.WriteLine("---| Speed - " + device.Speed);
        }
    }
}
