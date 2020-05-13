using System;

namespace Swift.Net.Exceptions
{
    public class SwiftParserException : Exception
    {
        public SwiftParserException()
        {
        }

        public SwiftParserException(string message) : base(message)
        {
        }

        public SwiftParserException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}
