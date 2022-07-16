using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Serialization
{
    [Serializable]
    public class Subject
    {
        [XmlAttribute(AttributeName ="SubjectName")]
        public string Name { get; set; }
        //[XmlAttribute]
        //[JsonProperty("Derece")]
        public int Degree { get; set; }
        //[XmlIgnore]
        [JsonIgnore]
        public int Lessons { get; set; }
        public Subject()
        {

        }
        public override string ToString()
        {
            return $"{Name} - {Degree} - {Lessons}";
        }
    }
}
