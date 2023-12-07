using System;
using System.Text;
using System.IO.Pipes;
using System.Diagnostics;

namespace Pipel
{
    public class PipeClient
    {
        int TimeOut = 1000;
        public void Send(string text, string name)
        {
            try
            {
                NamedPipeClientStream pipeStream = new NamedPipeClientStream(".", name, PipeDirection.Out, PipeOptions.Asynchronous);

                // The connect function will indefinitely wait for the pipe to become available
                // If that is not acceptable specify a maximum waiting time (in ms)
                pipeStream.Connect(TimeOut);
                Debug.WriteLine("[Client] Pipe connection established");

                byte[] buffer = Encoding.UTF8.GetBytes(text);
                pipeStream.BeginWrite(buffer, 0, buffer.Length, AsyncSend, pipeStream);
            }
            catch (TimeoutException ex)
            {
                Debug.WriteLine(ex.Message);
            }
        }

        private void AsyncSend(IAsyncResult iar)
        {
            try
            {
                NamedPipeClientStream pipeStream = (NamedPipeClientStream)iar.AsyncState;

                pipeStream.EndWrite(iar);
                pipeStream.Flush();
                pipeStream.Close();
                pipeStream.Dispose();
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
        }
    }
}