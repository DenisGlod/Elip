using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace ElipModel.Util
{
    public class Util
    {
        public static byte[] Serializatoin(object obj)
        {
            byte[] result;
            var bf = new BinaryFormatter();
            using (var ms = new MemoryStream())
            {
                bf.Serialize(ms, obj);
                result = ms.ToArray();
            }
            return result;
        }

        public static object Deserialization(byte[] vs)
        {
            object result;
            var bf = new BinaryFormatter();
            using (var ms = new MemoryStream(vs))
            {
                result = bf.Deserialize(ms);
            }
            return result;
        }
    }
}
