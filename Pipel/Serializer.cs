using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Serialize
{
    public static class Serializer
    {
        public static string Serialize(this object obj, bool formatted = false)
        {
            return JsonConvert.SerializeObject(obj, formatted ? Formatting.Indented : Formatting.None);
        }

        public static T DeSerialize<T>(string data)
        {
            return JsonConvert.DeserializeObject<T>(data);
        }

        public static T ConvertLoad<T>(object load)
        {
            if(typeof(T) == typeof(string) && ((JToken)load).Type == JTokenType.String)
                return (T)(object)load.ToString();

            return DeSerialize<T>(load.ToString());
        }
    }
}