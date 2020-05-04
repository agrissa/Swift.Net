using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace SwiftWriter.Exceptions
{
    public class SwiftWriterException : Exception
    {
        public SwiftWriterException()
        {
        }

        public SwiftWriterException(string message) : base(message)
        {
        }

        public SwiftWriterException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}
