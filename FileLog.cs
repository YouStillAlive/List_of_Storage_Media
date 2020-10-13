using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;


namespace List_of_Storage_Media
{
    class FileLog : ILog
    {
        private static bool first_run;

        public FileLog()
        {
            first_run = true;
            File.Delete("Print.txt");
        }

        public void Print(Storage value)
        {
            if (first_run)
                first_run = false;
            FileStream file = new FileStream("Print.txt", FileMode.Append, FileAccess.Write);
            BinaryWriter writer = new BinaryWriter(file);
            writer.Write(value.Name_Company);
            writer.Write(value.Name);
            writer.Write(value.Model);
            writer.Write(value.Speed);
            writer.Write(value.Capacity);
            writer.Write(value.Count);
            writer.Close();
            file.Close();
        }
    }
}