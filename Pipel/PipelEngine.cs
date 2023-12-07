
namespace Pipel
{
    public delegate void MessageDelegate(PipelMessage message);

    public static class PipelEngine
    {
        private static PipeServer Server;
        private static PipeClient Client = new PipeClient();
        public static bool Status => Server != null;

        public static event MessageDelegate Receive;

        public static void Start(string name)
        {
            Server = new PipeServer();
            Server.PipeReceive += MessageReceived;
            Server.Listen(name);
        }

        public static void Stop()
        {
            Server.PipeReceive -= MessageReceived;
            Server = null;
        }

        public static void SetName(string name)
        {
            Stop();
            Start(name);
        }
        public static string GetName() => Server.PipeName;


        public static void SetCharacterLimit(int limit) => Server.CharacterLimit = limit;
        public static int GetCharacterLimit() => Server.CharacterLimit;


        public static void Send(string text, string name)
        {
            Send(new PipelMessage { Load = text, Sender = Server.PipeName }, name);
        }
        public static void Send(object load, string name)
        {
            Send(new PipelMessage { Load = load, Sender = Server.PipeName }, name);
        }
        public static void Send(PipelMessage messageObject, string name)
        {
            messageObject.Sender = Server.PipeName;
            Client.Send(messageObject.GetJson(), name);
        }

        private static void MessageReceived(string message)
        {
            PipelMessage mObject = PipelMessage.GetMessageObject(message);

            Receive?.Invoke(mObject);
        }
    }
}
