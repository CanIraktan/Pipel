using System;
using Newtonsoft.Json;
using Serialize;

namespace Pipel
{
    public class PipelMessage
    {
        public object Load { get; set; }
        [JsonProperty]
        public string Sender { get; internal set; }

        public void Send(string name)
        {
            PipelEngine.Send(this, name);
        }
        public static void Send(object load, string name)
        {
            PipelEngine.Send(new PipelMessage{Load = load}, name);
        }
        
        public string GetJson()
        {
            return this.Serialize();
        }

        public T ConvertLoad<T>()
        {
            //if(typeof(T) == typeof(string) && ((JsonElement)this.Load).ValueKind == JsonValueKind.String)
            //    return (T)(object)this.Load.ToString();
            //return (T)Convert.ChangeType(this.Load.ToString(), typeof(T));

            return Serializer.ConvertLoad<T>(this.Load.ToString());
        }

        public static PipelMessage GetMessageObject(string dataStr)
        {
            return Serializer.DeSerialize<PipelMessage>(dataStr);
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}