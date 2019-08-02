using System.Net;
using System;

namespace HttpServer
{
    public class Listener
    {
      public  HttpListener HttpListener { get;  }

        public Listener(HttpListener listener)
        {
            HttpListener = listener;
        }
        public void StartListening(HttpListener listener)
        {
            Console.WriteLine("Listening....");
            listener.Start();
        }

        public void StopListening(HttpListener listener)
        {
            listener.Stop();
        }
    }
}
