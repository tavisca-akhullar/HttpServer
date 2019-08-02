using System.Net;
using System.IO;

namespace HttpServer
{
    public class WebServer
    {
        private Request _request { get; set; }
        private Response _response { get; set; }
        private Converter _converter { get; set; }
        private Listener _listener { get; set; }
        private Context _context { get; set; }
        private Url _uri { get; set; }
        private WebPage _webPage { get; set; }
        public WebServer(Url uri,WebPage webPage)
        {
            _uri = uri;
            _webPage = webPage;
            _context = new Context();
            _request = new Request();
            _response = new Response();
            _listener = new Listener(new HttpListener());
            _converter = new Converter();
        }

        public void SendRequest()
        {
            _listener.HttpListener.Prefixes.Add(_uri.Link);
            _listener.StartListening(_listener.HttpListener);
            _context.HttpContext = _listener.HttpListener.GetContext();
            _request.HttpRequest = _context.HttpContext.Request;
            _response.HttpResponse= _context.HttpContext.Response;
        }

        public void ReceiveResponse()
        {
            byte[] buffer = _converter.ConvertToBytes(_webPage.Contents);
            _response.HttpResponse.ContentLength64 = buffer.Length;
            Stream output = _response.HttpResponse.OutputStream;
            output.Write(buffer, 0, buffer.Length);
            _listener.StopListening(_listener.HttpListener);
        }

        public HttpListenerRequest GetRequest()
        {
            return _request.HttpRequest;
        }

        public HttpListenerResponse GetResponse()
        {
            return _response.HttpResponse;
        }
    }
}
