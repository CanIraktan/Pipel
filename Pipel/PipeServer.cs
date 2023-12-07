using System;
using System.Text;
using System.IO.Pipes;
using System.Diagnostics;

namespace Pipel
{
    public delegate void PipeMessageDelegate(string reply);

    public class PipeServer
    {
        public event PipeMessageDelegate PipeReceive;
        //string _pipeName;
        public string PipeName { get; protected set; }
        internal int CharacterLimit { get; set; } = 5000;

        public void Listen(string pipeName)
        {
            try
            {
                // Set to class level var so we can re-use in the async callback method
                PipeName = pipeName;
                // Create the new async pipe 
                NamedPipeServerStream pipeServer = new NamedPipeServerStream(PipeName, PipeDirection.In, 1, PipeTransmissionMode.Byte, PipeOptions.Asynchronous);

                // Wait for a connection
                pipeServer.BeginWaitForConnection(new AsyncCallback(WaitForConnectionCallBack), pipeServer);
                
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
        }

        private void WaitForConnectionCallBack(IAsyncResult iar)
        {
            try
            {
                // Get the pipe
                NamedPipeServerStream pipeServer = (NamedPipeServerStream)iar.AsyncState;
                // End waiting for the connection
                pipeServer.EndWaitForConnection(iar);

                byte[] buffer = new byte[CharacterLimit];

                // Read the incoming message
                int boyut = pipeServer.Read(buffer, 0, CharacterLimit);

                // Convert byte buffer to string
                //string stringData = Encoding.UTF8.GetString(buffer, 0, buffer.Length);
                string stringData = Encoding.UTF8.GetString(buffer, 0, boyut);

                //if (stringData.Contains("\0\0"))
                //    stringData = stringData.Substring(0, stringData.IndexOf("\0\0", StringComparison.Ordinal));

                Debug.WriteLine(stringData + Environment.NewLine);

                // Pass message back to calling form
                PipeReceive?.Invoke(stringData);

                // Kill original sever and create new wait server
                pipeServer.Close();
                //pipeServer = null;
                pipeServer = new NamedPipeServerStream(PipeName, PipeDirection.In, 1, PipeTransmissionMode.Byte, PipeOptions.Asynchronous);

                // Recursively wait for the connection again and again....
                pipeServer.BeginWaitForConnection(new AsyncCallback(WaitForConnectionCallBack), pipeServer);
            }
            catch
            {
                //return;
            }
        }
    }
}
