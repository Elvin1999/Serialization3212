using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serialization
{
    [Serializable]
    public class Translator
    {
        public List<Subject> Subjects { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Id { get; set; }
        public string Fullname => $"{Name} - {Surname}";

        public override string ToString()
        {
            if (Subjects != null)
            {
                foreach (var subject in Subjects)
                {
                    Console.WriteLine(subject);
                }
            }
            return $"{Id} {Fullname}";
        }
    }
}
