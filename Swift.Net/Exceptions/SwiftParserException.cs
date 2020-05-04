using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

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
