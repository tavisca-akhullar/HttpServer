using System;

namespace HttpServer
{
    public class WebPage
    {
        public String Contents { get;  }

      public  WebPage(String contents)
        {
            Contents = contents;
        }
    }
}
