using Newtonsoft.Json;

namespace benchmark_serilizer.Serilizer
{
    public static class JsonSerilizer
    {
        public static string Serilizer(object value)
        {
            return JsonConvert.SerializeObject(value);
        }

        public static object Deserilize(string value)
        {
            return JsonConvert.DeserializeObject(value);
        }

        public static T Deserilize<T>(string value) where T : class
        {
            return JsonConvert.DeserializeObject<T>(value);
        }
    }
}