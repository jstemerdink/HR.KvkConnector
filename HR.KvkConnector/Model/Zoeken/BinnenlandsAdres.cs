using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace HR.KvkConnector.Model.Zoeken
{
    [DataContract]
    public class BinnenlandsAdres
    {
        [DataMember(Name = "type")]
        public string Type { get; set; }

        [DataMember(Name = "straatnaam")]
        public string StraatNaam { get; set; }

        [DataMember(Name = "huisnummer")]
        public int? HuisNummer { get; set; }

        [DataMember(Name = "postbusnummer")]
        public int? PostbusNummer { get; set; }

        [DataMember(Name = "postcode")]
        public string Postcode { get; set; }

        [DataMember(Name = "plaats")]
        public string Plaats { get; set; }

        [DataMember(Name = "huisletter")]
        public string HuisLetter { get; set; }
    }
}
