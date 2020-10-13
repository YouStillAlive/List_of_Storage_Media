using System;
using System.IO;
using System.Runtime.Serialization;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List_of_Storage_Media
{
    class XMLSerialize : ISerialize
    {
        public void Save(List<Storage> value)
        {
            FileStream stream = new FileStream("save.xml", FileMode.Create);
            XmlSerializer serializer = new XmlSerializer(typeof(List<Storage>));
            serializer.Serialize(stream, value);
            stream.Close();
        }

        public List<Storage> Load()
        {
            FileStream stream = new FileStream("save.xml", FileMode.Open);
            XmlSerializer deserialize = new XmlSerializer(typeof(List<Storage>));
            List<Storage> temp = (List<Storage>)deserialize.Deserialize(stream);
            stream.Close();
            return temp;
        }
    }
}
