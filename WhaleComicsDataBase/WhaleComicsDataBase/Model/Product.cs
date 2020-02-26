using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace WhaleComicsDataBase
{
    [DataContract]
    public class Product
    {
        [DataMember]
        public string ProductName { get; set; }
        [DataMember]
        public string ProductType { get; set; }
        [DataMember]
        public int ProductPrice { get; set; }
        [DataMember]
        public int ProductQuanity { get; set; }
        [DataMember]
        public int ProductNumber { get; set; }
        [DataMember]
        public string PruductGenre { get; set; }
        [DataMember]
        public string ProductImage { get; set; }
    }
}
