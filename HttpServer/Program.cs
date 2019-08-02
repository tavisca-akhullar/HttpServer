using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HttpServer
{
    class Program
    {
        static void Main(string[] args)
        {
            String pageContent= 

            "<html>" +

            "  <head>" +

            "    <title>HttpListener Example</title>" +

            "  </head>" +

            "  <body>" +
            

            "    <B1>Hello World!</B1>" +


            "  </body>" +

            "</html>";

            Url uri = new Url("http://localhost:5050/");
            WebPage webPage = new WebPage(pageContent);
            WebServer server = new WebServer(uri,webPage);
            server.SendRequest();
            server.ReceiveResponse();
        }
    }
}
