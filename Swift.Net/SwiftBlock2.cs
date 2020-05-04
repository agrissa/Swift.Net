using System;
using System.Collections.Generic;
using System.Text;

namespace Swift.Net
{
    public abstract class SwiftBlock2 : SwiftBlockBase
    {
        public Direction Direction { get; set; }
        public string MessageType { get; set; }
        public string MessagePriority { get; set; }

        public override string BlockName => "Application header";
        public override int BlockIdentifier => 2;

        public override bool Equals(object obj)
        {
            if (obj == null) { return false; }
            if (ReferenceEquals(this, obj)) { return true; }
            return obj is SwiftBlock2 block &&
               Direction == block.Direction &&
               MessageType == block.MessageType &&
               MessagePriority == block.MessagePriority &&
               BlockName == block.BlockName &&
               BlockIdentifier == block.BlockIdentifier;
        }

        public override int GetHashCode()
        {
            int hashCode = -201832364;
            hashCode = hashCode * -1521134295 + Direction.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(MessageType);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(MessagePriority);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(BlockName);
            hashCode = hashCode * -1521134295 + BlockIdentifier.GetHashCode();
            return hashCode;
        }
    }
}
