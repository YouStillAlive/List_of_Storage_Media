using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Json;

using System.Text;
using System.Threading.Tasks;

namespace List_of_Storage_Media
{
    class JSONSerialize : ISerialize
    {
        public void Save(List<Storage> value)
        {
            FileStream stream = new FileStream("save.json", FileMode.Create);
            DataContractJsonSerializer jsonFormatter = new DataContractJsonSerializer(typeof(List<Storage>));
            jsonFormatter.WriteObject(stream, value);
            stream.Close();
        }

        public List<Storage> Load()
        {
            FileStream stream = new FileStream("save.json", FileMode.Open);
            DataContractJsonSerializer jsonFormatter = new DataContractJsonSerializer(typeof(List<Storage>));
            List<Storage> temp = (List<Storage>)jsonFormatter.ReadObject(stream);
            stream.Close();
            return temp;
        }
    }
}
    