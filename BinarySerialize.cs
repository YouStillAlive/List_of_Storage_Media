using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace List_of_Storage_Media
{
    class BinarySerialize : ISerialize
    {
        public void Save(List<Storage> value)
        {
            FileStream stream = new FileStream("save.txt", FileMode.Create);
            BinaryFormatter formatter = new BinaryFormatter();
            formatter.Serialize(stream, value);
            stream.Close();
        }

        public List<Storage> Load()
        {
            FileStream stream = new FileStream("save.txt", FileMode.Open);
            BinaryFormatter formatter = new BinaryFormatter();
            List<Storage> temp = (List<Storage>)formatter.Deserialize(stream);
            stream.Close();
            return temp;
        }
    }
}
