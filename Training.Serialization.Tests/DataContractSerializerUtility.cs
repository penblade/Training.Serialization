using System.IO;
using System.Runtime.Serialization;
using System.Text;

namespace Training.Serialization.Tests
{
    internal static class DataContractSerializerUtility
    {
        /// <summary>
        /// Serialize the object to xml.
        /// 
        /// The following assumptions will help us track down issues.
        /// If the item is null then the StreamReader will throw an exception.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="item"></param>
        /// <returns></returns>
        internal static string Serialize<T>(T item) where T : class
        {
            using (var stream = new MemoryStream())
            using (var reader = new StreamReader(stream, Encoding.UTF8))
            {
                var serializer = new DataContractSerializer(typeof(T));
                serializer.WriteObject(stream, item);
                stream.Position = 0;
                return reader.ReadToEnd();
            }
        }

        /// <summary>
        /// Deserialize the xml to the object.
        /// 
        /// The following assumptions will help us track down issues.
        /// If the xml is null then the StreamWriter will throw an exception.
        /// If the xml cannot be deserialized to the object,
        ///    then casting to the object will throw an exception.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="xml"></param>
        /// <returns></returns>
        internal static T Deserialize<T>(string xml) where T : class
        {
            using (var stream = new MemoryStream())
            using (var writer = new StreamWriter(stream, Encoding.UTF8))
            {
                writer.Write(xml);
                writer.Flush();
                stream.Position = 0;
                var serializer = new DataContractSerializer(typeof(T));
                return (T)serializer.ReadObject(stream);
            }
        }
    }
}
