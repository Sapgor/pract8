using System.IO;
using System.Xml.Serialization;

namespace SerializationLibrary
{
    public class Serialization
    {
        public static void Serialize<T>(T data, string filePath)
        {
            using (var stream = new FileStream(filePath, FileMode.Create))
            {
                var serializer = new XmlSerializer(typeof(T));
                serializer.Serialize(stream, data);
            }
        }

        public static T Deserialize<T>(string filePath)
        {
            using (var stream = new FileStream(filePath, FileMode.Open))
            {
                var serializer = new XmlSerializer(typeof(T));
                return (T)serializer.Deserialize(stream);
            }
        }
    }
}