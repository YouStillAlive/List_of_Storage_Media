using System;
using System.Runtime.Serialization;

namespace List_of_Storage_Media
{
    [Serializable]
    [DataContract]
    public class DVD : Storage
    {
        private int speed_write;

        public DVD() : base()
        {
            speed_write = 0;
        }

        [DataMember]
        public override int Speed
        {
            get => speed_write;
            set { speed_write = value; }
        }

        public override void Print(ILog p)
        {
            p.Print(this);
        }
    }
}
