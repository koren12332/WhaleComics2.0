using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace WhaleComicsDataBase
{
    [DataContract]
    public class Order
    {
        [DataMember]
        public User User { get; set; }
        [DataMember]
        public Product Product { get; set; }
        [DataMember]
        public int OrderNumber { get; set; }
        [DataMember]
        public DateTime OrderDate { get; set; }
        [DataMember]
        public int Amount { get; set; }

    }
}
