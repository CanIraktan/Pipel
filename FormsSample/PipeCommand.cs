using System;
using Serialize;

namespace Pipel
{
    public class PipeCommand
    {
        public PipeMessageTypes Type { get; set; }
        public object Load { get; set; }

        public PipeCommand (PipeMessageTypes type, object load)
        {
            Type = type;
            Load = load;
        }

        public void Send(string name)
        {
            PipelMessage.Send(this, name);
        }

        public static void Send(PipeMessageTypes type, object load, string name)
        {
            new PipeCommand(type, load).Send(name);
        }

        public static PipeCommand GetCommand(PipelMessage message)
        {
            return message.ConvertLoad<PipeCommand>();
        }

        public T ConvertLoad<T>()
        {
            return Serializer.ConvertLoad<T>(this.Load.ToString());
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}