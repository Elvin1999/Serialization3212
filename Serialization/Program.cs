using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;

namespace Serialization
{
    public class Program
    {
        static void Main(string[] args)
        {
            #region XML Serialize
            var army = new TranslatorArmy
            {
                Name = "Step IT Academy",
                Location = "Koroglu Rehimov 71",
                Translators = new List<Translator>
                {
                    new Translator
                    {
                        Name="Tural",
                        Surname="Eliyev",
                        Id=1,
                        Subjects=new List<Subject>
                        {
                            new Subject
                            {
                                 Name="C++",
                                 Degree=42,
                                 Lessons=30
                            },
                            new Subject
                            {
                                 Name="C#",
                                 Degree=42,
                                 Lessons=35
                            },
                        }
                    },
                    new Translator
                    {
                        Name="Eli",
                        Surname="Memmedov",
                        Id=2,
                        Subjects=new List<Subject>
                        {
                            new Subject
                            {
                                 Name="JS",
                                 Degree=42,
                                 Lessons=30
                            },
                            new Subject
                            {
                                 Name="PHP",
                                 Degree=42,
                                 Lessons=35
                            },
                        }
                    },
                    new Translator
                    {
                        Name="Leyla",
                        Surname="Mammadli",
                        Id=3,
                        Subjects=new List<Subject>
                        {
                            new Subject
                            {
                                 Name="Angular",
                                 Degree=42,
                                 Lessons=30
                            },
                            new Subject
                            {
                                 Name="React",
                                 Degree=42,
                                 Lessons=35
                            },
                        }
                    }
                }
            };


            //var xml = new XmlSerializer(typeof(TranslatorArmy));
            //using (var fs=new FileStream("TranslatorArmy.xml",FileMode.OpenOrCreate))
            //{
            //    xml.Serialize(fs, army);
            //}

            #endregion



            #region XML DESERIALIZE

            //TranslatorArmy army = null;



            //var xml = new XmlSerializer(typeof(TranslatorArmy));
            //using (var fs = new FileStream("TranslatorArmy.xml",FileMode.OpenOrCreate))
            //{
            //    army=xml.Deserialize(fs) as TranslatorArmy;
            //}
            //Console.WriteLine(army);

            #endregion


            #region Binary Serialization

            //var database = new Translator[]
            //{
            //    new Translator
            //    {
            //         Id=1,
            //         Name="Rafiq",
            //         Surname="Rafiqli"
            //    },
            //    new Translator
            //    {
            //         Id=2,
            //         Name="Coshgun",
            //         Surname="Mammadli"
            //    },
            //    new Translator
            //    {
            //         Id=3,
            //         Name="Rafiq",
            //         Surname="Rafiqli"
            //    },
            //};


            //var bf = new BinaryFormatter();
            //using (var fs=new FileStream("file.bin",FileMode.OpenOrCreate))
            //{
            //    bf.Serialize(fs, database);
            //}


            #endregion


            #region Binary Deserialization
            //Translator[] db = null;
            //var bf=new BinaryFormatter();
            //using (var fs=new FileStream("file.bin",FileMode.OpenOrCreate))
            //{
            //    db = bf.Deserialize(fs) as Translator[];
            //}

            //if (db != null)
            //{
            //    foreach (Translator translator in db)
            //    {
            //        Console.WriteLine(translator);
            //    }
            //}

            #endregion


            #region Json Serialization

            //var serializer = new JsonSerializer();

            //using (var sw = new StreamWriter("army.json"))
            //{
            //    using (var jw = new JsonTextWriter(sw))
            //    {
            //        jw.Formatting = Formatting.Indented;
            //        serializer.Serialize(jw, army);
            //    }
            //}

            #endregion


            //TranslatorArmy resultArmy = null;
            //var serializer=new JsonSerializer();
            //using (var sr=new StreamReader("army.json"))
            //{
            //    using (var jr=new JsonTextReader(sr))
            //    {
            //        resultArmy = serializer.Deserialize<TranslatorArmy>(jr);
            //    }
            //}
            //Console.WriteLine(resultArmy);
        }
    }
}