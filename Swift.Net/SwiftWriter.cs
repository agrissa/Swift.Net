using SwiftWriter.Exceptions;
using System;
using System.Collections.Generic;
using System.Text;

namespace Swift.Net
{
    public class SwiftWriter
    {
        private StringBuilder stringBuilder = new StringBuilder();

        public SwiftWriter()
        {
        }

        public string GetFinMessage(SwiftMessage message)
        {
            Write(message);
            return stringBuilder.ToString(); ;
        }

        private void Write(SwiftMessage message)
        {
            WriteBlock1(message.Block1);
            WriteBlock2(message.Block2);
            WriteBlock3(message.Block3);
            WriteBlock4(message.Block4);
            WriteBlock5(message.Block5);
        }

        private void WriteBlock1(SwiftBlock1 block1)
        {
            if (block1 == null)
                throw new SwiftWriterException("The block 1 is mandatory");
            Append("{1:");
            Append(block1.ToString());
            Append("}");
        }

        private void WriteBlock2(SwiftBlock2 block2)
        {
            if (block2 == null)
                throw new SwiftWriterException("The block 2 is mandatory");
            Append("{2:");
            Append(block2.ToString());
            Append("}");
        }

        private void WriteBlock3(SwiftBlock3 block3)
        {
            if (block3 == null)
                return;
            Append("{3:");
            Append(block3.ToString());
            Append("}");
        }

        private void WriteBlock4(SwiftBlock4 block4)
        {
            if (block4 == null)
                return;
            Append("{4:\r\n");
            Append(block4.ToString());
            Append("\r\n-}");
        }

        private void WriteBlock5(SwiftBlock5 block5)
        {
            if (block5 == null)
                return;
            Append("{5:");
            Append(block5.ToString());
            Append("}");
        }

        private void Append(string text)
        {
            stringBuilder.Append(text);
        }
    }
}
