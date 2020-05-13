using System;

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
