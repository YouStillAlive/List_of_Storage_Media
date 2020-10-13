using System;
using System.Runtime.Serialization;

namespace List_of_Storage_Media
{
    [Serializable]
    [DataContract]
    public class HDD : Storage
    {
        private int speed;

        public HDD() : base()
        {
            speed = 0;
        }

        [DataMember]
        public override int Speed
        {
            get => speed;
            set { speed = value; }
        }

        public override void Print(ILog p)
        {
            p.Print(this);
        }
    }
}