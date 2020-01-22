using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace WhaleComicsDataBase
{
    [DataContract]
    public class User
    {
        [DataMember]
        public string UserName { get; set; }
        [DataMember]
        public string UserEmail { get; set; }
        [DataMember]
        public string UserAddress { get; set; }
        [DataMember]
        public string UserPassword { get; set; }
        [DataMember]
        public string UserPhoneNumber { get; set; }
    }
}
