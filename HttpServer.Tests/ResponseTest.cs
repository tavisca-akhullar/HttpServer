using System;
using System.Collections.Generic;
using System.Text;
using HttpServer;
using Xunit;

namespace HttpServer.Tests
{
    public class ResponseTest
    {
        [Fact]
        public void HttpResponsTest()
        {
            String pageContent =

         "<html>" +

         "  <head>" +

         "    <title>HttpListener Example</title>" +

         "  </head>" +

         "  <body>" +


         "    <B1>Hello World!</B1>" +


         "  </body>" +

         "</html>";

            Url uri = new Url("http://localhost:8080/");
            WebPage webPage = new WebPage(pageContent);
            WebServer server = new WebServer(uri, webPage);
            server.SendRequest();
            server.ReceiveResponse();
            Assert.Equal("200", server.GetResponse().StatusCode.ToString());

        }
    }
}
