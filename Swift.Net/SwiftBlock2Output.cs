using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Swift.Net
{
    public class SwiftBlock2Output : SwiftBlock2
    {
        public string InputTime { get; set; }
        public MessageInputReference MessageInputReference { get; set; }
        public string ReceiverOutputDate { get; set; }
        public string ReceiverOutputTime { get; set; }

        public SwiftBlock2Output()
        {
        }

        public SwiftBlock2Output(string blockText) : base()
        {
            SetValue(blockText);
        }

        public override string GetValue()
        {
            StringBuilder result = new StringBuilder("O");

            if (!string.IsNullOrEmpty(MessageType))
            {
                result.Append(MessageType);
            }
            if (!string.IsNullOrEmpty(InputTime))
            {
                result.Append(InputTime);
            }
            if (MessageInputReference != null)
            {
                if (!string.IsNullOrEmpty(MessageInputReference.InputDate))
                {
                    result.Append(MessageInputReference.InputDate);
                }
                if (!string.IsNullOrEmpty(MessageInputReference.LogicalTerminalAddress))
                {
                    result.Append(MessageInputReference.LogicalTerminalAddress);
                }
                if (!string.IsNullOrEmpty(MessageInputReference.SessionNumber))
                {
                    result.Append(MessageInputReference.SessionNumber);
                }
                if (!string.IsNullOrEmpty(MessageInputReference.SequenceNumber))
                {
                    result.Append(MessageInputReference.SequenceNumber);
                }
            }
            if (!string.IsNullOrEmpty(ReceiverOutputDate))
            {
                result.Append(ReceiverOutputDate);
            }
            if (!string.IsNullOrEmpty(ReceiverOutputTime))
            {
                result.Append(ReceiverOutputTime);
            }
            if (!string.IsNullOrEmpty(MessagePriority))
            {
                result.Append(MessagePriority);
            }

            return result.ToString();
        }

        public override void SetValue(string blockText)
        {
            if (blockText == null)
                throw new ArgumentNullException("blockText");

            //1a 3n HHMM YYMMDD12x4!n6!n YYMMDD HHMM 1a
            Regex regex = new Regex(@"^(2:)?O\d{3}((2[0-3])|([01]\d))[0-5]\d\d{2}(((0)\d)|((1)[0-2]))([0-2]\d|(3)[01])\w{12}\d{4}\d{6}\d{2}(((0)\d)|((1)[0-2]))([0-2]\d|(3)[01])((2[0-3])|([01]\d))[0-5]\d[SUN]?$");
            if (!regex.IsMatch(blockText))
                throw new ArgumentException($"Invalid format");

            int offset = 0;
            if (blockText.StartsWith("2:"))
                offset += 2;

            Direction = Direction.Output;
            offset++;

            MessageType = blockText.Substring(offset, 3);
            offset += 3;

            InputTime = blockText.Substring(offset, 4);
            offset += 4;

            //MIR
            MessageInputReference = new MessageInputReference();
            MessageInputReference.InputDate = blockText.Substring(offset, 6);
            offset += 6;

            MessageInputReference.LogicalTerminalAddress = blockText.Substring(offset, 12);
            offset += 12;

            MessageInputReference.SessionNumber = blockText.Substring(offset, 4);
            offset += 4;

            MessageInputReference.SequenceNumber = blockText.Substring(offset, 6);
            offset += 6;

            ReceiverOutputDate = blockText.Substring(offset, 6);
            offset += 6;

            ReceiverOutputTime = blockText.Substring(offset, 4);
            offset += 4;

            if (offset < blockText.Length)
                MessagePriority = blockText.Substring(offset, 1);

        }

        public override bool Equals(object obj)
        {
            if (obj == null) { return false; }
            if (ReferenceEquals(this, obj)) { return true; }
            return obj is SwiftBlock2Output output &&
                   base.Equals(obj) &&
                   InputTime == output.InputTime &&
                   EqualityComparer<MessageInputReference>.Default.Equals(MessageInputReference, output.MessageInputReference) &&
                   ReceiverOutputDate == output.ReceiverOutputDate &&
                   ReceiverOutputTime == output.ReceiverOutputTime;
        }

        public override int GetHashCode()
        {
            int hashCode = -886955950;
            hashCode = hashCode * -1521134295 + base.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(InputTime);
            hashCode = hashCode * -1521134295 + EqualityComparer<MessageInputReference>.Default.GetHashCode(MessageInputReference);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(ReceiverOutputDate);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(ReceiverOutputTime);
            return hashCode;
        }

        public override string ToString()
        {
            return GetValue();
        }
    }
}
