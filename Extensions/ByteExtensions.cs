using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace benchmark_serilizer.Extension
{
    public static class ByteExtensions
    {
        public static TObject ToObject<TObject>(this byte[] arrBytes) where TObject : class
        {
            //   System.Console.WriteLine(arrBytes);
            if (arrBytes == null)
            {
                return (TObject)null;
            }

            MemoryStream memStream = new MemoryStream();
            BinaryFormatter binForm = new BinaryFormatter();
            memStream.Write(arrBytes, 0, arrBytes.Length);
            memStream.Seek(0, SeekOrigin.Begin);


            return (TObject)binForm.Deserialize(memStream);
        }
    }

}