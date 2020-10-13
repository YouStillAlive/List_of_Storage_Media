using System;
using System.Runtime.Serialization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization.Formatters.Soap;
using System.Xml.Serialization;
using System.Runtime.Serialization.Json;

namespace List_of_Storage_Media
{
    [Serializable]
    [KnownType(typeof(Flash))]
    [KnownType(typeof(DVD))]
    [KnownType(typeof(HDD))]
    [XmlInclude(typeof(Flash))]
    [XmlInclude(typeof(DVD))]
    [XmlInclude(typeof(HDD))]
    [DataContract]
    public abstract class Storage
    {
        protected string name_company, model, name;
        protected double capacity;
        protected int count;

        [DataMember]
        public int Count
        {
            get => count;
            set { count = value; }
        }

        [DataMember]
        public double Capacity
        {
            get => capacity;
            set { capacity = value; }
        }

        [DataMember]
        public string Name_Company
        {
            get => name_company;
            set { name_company = value; }
        }

        [DataMember]
        public string Model
        {
            get => model;
            set { model = value; }
        }

        [DataMember]
        public string Name
        {
            get => name;
            set { name = value; }
        }

        [DataMember]
        public abstract int Speed
        {
            get;
            set;
        }

        public Storage()
        {
            name_company = "";
            model = "";
            name = "";
            capacity = 0.0;
            count = 0;
        }

        virtual public void Print(ILog p)
        {
            p.Print(this);
        }
    }
}
