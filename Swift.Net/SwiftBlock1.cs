using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Swift.Net
{
    public class SwiftBlock1 : SwiftBlockBase
    {
        public string ApplicationId { get; set; }
        public string ServiceId { get; set; }
        public string LogicalTerminalAddress { get; set; }
        public string SessionNumber { get; set; }
        public string SequenceNumber { get; set; }

        public string BlockName => "Basic header";
        public int BlockIdentifier => 1;

        public SwiftBlock1()
        {
        }

        public SwiftBlock1(string blockText) : base()
        {
            SetValue(blockText);
        }

        public string GetValue()
        {
            StringBuilder result = new StringBuilder();

            if (!string.IsNullOrEmpty(ApplicationId))
            {
                result.Append(ApplicationId);
            }
            if (!string.IsNullOrEmpty(ServiceId))
            {
                result.Append(ServiceId);
            }
            if (!string.IsNullOrEmpty(LogicalTerminalAddress))
            {
                result.Append(LogicalTerminalAddress);
            }
            if (!string.IsNullOrEmpty(SessionNumber))
            {
                result.Append(SessionNumber);
            }
            if (!string.IsNullOrEmpty(SequenceNumber))
            {
                result.Append(SequenceNumber);
            }

            return result.ToString();
        }

        public void SetValue(string blockText)
        {
            if (blockText == null)
                throw new ArgumentNullException("blockText");

            Regex regex = new Regex(@"^(1:)?[FAL]\d{2}\w{12}\d{4}\d{6}$");
            if (!regex.IsMatch(blockText))
                throw new ArgumentException($"Invalid format");

            int offset = 0;
            if (blockText.StartsWith("1:"))
                offset += 2;

            ApplicationId = blockText.Substring(offset, 1);
            offset += 1;

            ServiceId = blockText.Substring(offset, 2);
            offset += 2;

            LogicalTerminalAddress = blockText.Substring(offset, 12);
            offset += 12;

            SessionNumber = blockText.Substring(offset, 4);
            offset += 4;

            SequenceNumber = blockText.Substring(offset, 6);
        }

        public override bool Equals(object obj)
        {
            if (obj == null) { return false; }
            if (ReferenceEquals(this, obj)) { return true; }
            return obj is SwiftBlock1 block &&
                   ApplicationId == block.ApplicationId &&
                   ServiceId == block.ServiceId &&
                   LogicalTerminalAddress == block.LogicalTerminalAddress &&
                   SessionNumber == block.SessionNumber &&
                   SequenceNumber == block.SequenceNumber &&
                   BlockName == block.BlockName &&
                   BlockIdentifier == block.BlockIdentifier;
        }

        public override int GetHashCode()
        {
            int hashCode = 82699558;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(ApplicationId);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(ServiceId);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(LogicalTerminalAddress);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(SessionNumber);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(SequenceNumber);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(BlockName);
            hashCode = hashCode * -1521134295 + BlockIdentifier.GetHashCode();
            return hashCode;
        }

        public override string ToString()
        {
            return GetValue();
        }
    }
}
