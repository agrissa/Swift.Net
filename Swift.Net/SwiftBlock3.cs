using System;
using System.Collections.Generic;
using System.Text;

namespace Swift.Net
{
    public class SwiftBlock3 : SwiftTagListBlock
    {
        public override string BlockName => "User header";
        public override int BlockIdentifier => 3;

        public SwiftBlock3()
        {
        }

        public SwiftBlock3(SwiftTagListBlock swiftTags) : base(swiftTags)
        {
        }

        public SwiftBlock3(string blockText)
        {
            SetValue(blockText);
        }

        public override void SetValue(string blockText)
        {
            SetBlockTags(blockText);
        }

        public override string GetValue()
        {
            return GetBlockTags();
        }

        public override bool Equals(object obj)
        {
            if (obj == null) { return false; }
            if (ReferenceEquals(this, obj)) { return true; }
            return obj is SwiftBlock3 block &&
                   base.Equals(obj) &&
                   BlockName == block.BlockName &&
                   BlockIdentifier == block.BlockIdentifier;
        }

        public override int GetHashCode()
        {
            int hashCode = 602327064;
            hashCode = hashCode * -1521134295 + base.GetHashCode();
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
