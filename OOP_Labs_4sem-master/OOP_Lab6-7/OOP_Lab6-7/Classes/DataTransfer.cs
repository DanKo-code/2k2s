using System.IO;
using System.Xml.Serialization;
using OOP_Lab6_7.Classes;

namespace OOP_Lab6_7
{
    public static class DataTransfer
    {
        public static void SerializeFilms(Cinema films)
        {
            var serializer = new XmlSerializer(typeof(Cinema));
            using (var fs = new FileStream(@"D:\2k2s\OOP_Labs_4sem-master\OOP_Lab6-7\OOP_Lab6-7\Resources\films.xml", 
                FileMode.Create))
            {
                serializer.Serialize(fs, films);
            }
        }


        public static Cinema DeserializeFilms()
        {
            var serializer = new XmlSerializer(typeof(Cinema));
            Cinema deserializedFilmsList = null;

            using (var fs = new FileStream(@"D:\2k2s\OOP_Labs_4sem-master\OOP_Lab6-7\OOP_Lab6-7\Resources\films.xml", 
                FileMode.OpenOrCreate))
            {
                if (fs.Length > 0)
                    deserializedFilmsList = serializer.Deserialize(fs) as Cinema;
            }

            return deserializedFilmsList;
        }
    }
}
