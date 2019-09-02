using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using Newtonsoft.Json;

namespace benchmark_serilizer.Extension
{
    public static class ObjectExteion
    {
        public static string ToJson(this object value)
        {
            return JsonConvert.SerializeObject(value);
        }
        public static byte[] ToByte(this object obj)
        {
            if (obj == null)
            {
                return null;
            }

            BinaryFormatter bf = new BinaryFormatter();
            using (MemoryStream ms = new MemoryStream())
            {
                bf.Serialize(ms, obj);

                return ms.ToArray();
            }

        }
    }

}