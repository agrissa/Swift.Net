using System;
using System.Collections.Generic;
using System.Text;

namespace Swift.Net
{
    public class SwiftMessage
    {
        public SwiftMessage()
        {
        }

        public SwiftBlock1 Block1 { get; set; }
        public SwiftBlock2 Block2 { get; set; }
        public SwiftBlock3 Block3 { get; set; }
        public virtual SwiftBlock4 Block4 { get; set; }
        public SwiftBlock5 Block5 { get; set; }

        public SwiftBlockBase GetBlock(int blocIdentifier)
        {
            switch (blocIdentifier)
            {
                case 1:
                    return this.Block1;
                case 2:
                    return this.Block2;
                case 3:
                    return this.Block3;
                case 4:
                    return this.Block4;
                case 5:
                    return this.Block5;
                default:
                    throw new ArgumentException("The block identifier must be between 1 and 5");
            }
        }

        public void SetBlock(SwiftBlockBase block)
        {
            if (block == null)
                throw new ArgumentNullException("block");

            switch (block.BlockIdentifier)
            {
                case 1:
                    Block1 = (SwiftBlock1)block;
                    break;
                case 2:
                    Block2 = (SwiftBlock2)block;
                    break;
                case 3:
                    Block3 = (SwiftBlock3)block;
                    break;
                case 4:
                    Block4 = (SwiftBlock4)block;
                    break;
                case 5:
                    Block5 = (SwiftBlock5)block;
                    break;
                default:
                    throw new ArgumentException("The block identifier must be between 1 and 5");
            }
        }

        public static SwiftMessage Parse(string message)
        {
            return new SwiftParser().GetSwiftMessage(message);
        }

        public static string Write(SwiftMessage message)
        {
            return new SwiftWriter().GetFinMessage(message);
        }

        public override bool Equals(object obj)
        {
            if (obj == null) { return false; }
            if (ReferenceEquals(this, obj)) { return true; }
            return obj is SwiftMessage message &&
                   EqualityComparer<SwiftBlock1>.Default.Equals(Block1, message.Block1) &&
                   EqualityComparer<SwiftBlock2>.Default.Equals(Block2, message.Block2) &&
                   EqualityComparer<SwiftBlock3>.Default.Equals(Block3, message.Block3) &&
                   EqualityComparer<SwiftBlock4>.Default.Equals(Block4, message.Block4) &&
                   EqualityComparer<SwiftBlock5>.Default.Equals(Block5, message.Block5);
        }

        public override int GetHashCode()
        {
            int hashCode = 195140915;
            hashCode = hashCode * -1521134295 + EqualityComparer<SwiftBlock1>.Default.GetHashCode(Block1);
            hashCode = hashCode * -1521134295 + EqualityComparer<SwiftBlock2>.Default.GetHashCode(Block2);
            hashCode = hashCode * -1521134295 + EqualityComparer<SwiftBlock3>.Default.GetHashCode(Block3);
            hashCode = hashCode * -1521134295 + EqualityComparer<SwiftBlock4>.Default.GetHashCode(Block4);
            hashCode = hashCode * -1521134295 + EqualityComparer<SwiftBlock5>.Default.GetHashCode(Block5);
            return hashCode;
        }

        public override string ToString()
        {
            return new SwiftWriter().GetFinMessage(this);
        }
    }
}