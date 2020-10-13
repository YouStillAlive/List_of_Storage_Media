using System;
using System.Runtime.Serialization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List_of_Storage_Media
{
    [Serializable]
    [DataContract]
    public class Flash : Storage
    {
        private int speed_USB;

        public Flash() : base()
        {
            speed_USB = 0;
        }

        [DataMember]
        public override int Speed
        {
            get => speed_USB;
            set { speed_USB = value; }
        }

        public override void Print(ILog p)
        {
            p.Print(this);
        }
    }
}
