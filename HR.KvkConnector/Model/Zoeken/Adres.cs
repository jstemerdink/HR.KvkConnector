using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using HR.KvkConnector.Model.Zoeken;

namespace HR.KvkConnector.Model.Zoeken
{
    [DataContract]
    public class Adres
    {
        [DataMember(Name = "binnenlandsAdres")]
        public BinnenlandsAdres BinnenlandsAdres { get; set; }
    }
}
