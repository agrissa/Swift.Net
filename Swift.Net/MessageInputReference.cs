using System;

namespace Swift.Net
{
    public class MessageInputReference
    {
        public virtual string InputDate { get; set; }
        public string LogicalTerminalAddress { get; set; }
        public string SessionNumber { get; set; }
        public string SequenceNumber { get; set; }

        public override bool Equals(object obj)
        {
            if (obj == null) { return false; }
            if (ReferenceEquals(this, obj)) { return true; }
            return obj is MessageInputReference reference &&
                   InputDate == reference.InputDate &&
                   LogicalTerminalAddress == reference.LogicalTerminalAddress &&
                   SessionNumber == reference.SessionNumber &&
                   SequenceNumber == reference.SequenceNumber;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(InputDate, LogicalTerminalAddress, SessionNumber, SequenceNumber);
        }
    }
}