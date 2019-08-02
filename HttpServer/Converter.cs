using System;

namespace HttpServer
{
    public class Converter
    {
        public byte[] ConvertToBytes(String value)
            {
            return System.Text.Encoding.UTF8.GetBytes(value);
            }
    }
}
