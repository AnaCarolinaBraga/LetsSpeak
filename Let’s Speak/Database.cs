using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Let_s_Speak
{
    public class Database
    {
        public enum DatabaseOption { englishDictionary }
        private static readonly string _rootDirectory = AppDomain.CurrentDomain.BaseDirectory;
        private static readonly string _engliswordsDb = Path.Combine(_rootDirectory, "englishwords.xml");

        public static List<EnglishDictionary> englishDictionary = new List<EnglishDictionary>();


        static Database()
        {
            InitializeDatabase();
        }

        public static void InitializeDatabase()
        {
            if (!File.Exists(_engliswordsDb))
            {
                englishDictionary.Add(new EnglishDictionary { Palavra = "Orange", Traducao = "Laranja" });
                Save(DatabaseOption.englishDictionary);
            }
            Load(DatabaseOption.englishDictionary);
        }

        private static void Load(DatabaseOption options)
        {
            if (options == DatabaseOption.englishDictionary)
            {
                XmlSerializer englishDictionarySerializer = new XmlSerializer(typeof(List<EnglishDictionary>));
                using (TextReader reader = new StreamReader(_engliswordsDb))
                {
                    var englishWords = englishDictionarySerializer.Deserialize(reader) as List<EnglishDictionary>;
                    englishDictionary = englishWords ?? new List<EnglishDictionary>();
                }
            }
        }

        public static void Save(DatabaseOption options)
        {
            Console.WriteLine("Salvando...");

            if (options == DatabaseOption.englishDictionary)
            {
                XmlSerializer englishDictionarySerializer = new XmlSerializer(typeof(List<EnglishDictionary>));
                using (TextWriter writer = new StreamWriter(_engliswordsDb))
                {
                    englishDictionarySerializer.Serialize(writer, englishDictionary);
                }
            }
            Console.WriteLine("Salvo.");
        }

        public static void Search(String searchWord)
        {

            //foreach (EnglishDictionary word in englishDictionary)
            //{
            //    string search = word.Palavra;
            //    if (search.Equals(searchWord))
            //    {
            //        Console.WriteLine(search);
            //    }
            //}
            //int count = 0;
            //foreach (var line in File.ReadAllLines(_engliswordsDb))
            //{
            //    if (line.Contains(searchWord))
            //    {
            //        Console.WriteLine(line);
            //        count++;
            //    } 
            //}
            //if(count == 0)
            //    Console.WriteLine("Não foi possível encontrar o termo pesquisado.");
        }
    }
}
