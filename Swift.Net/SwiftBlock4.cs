using System;
using System.Collections.Generic;
using System.Text;

namespace Swift.Net
{
    public class SwiftBlock4 : SwiftTagListBlock
    {
        public override string BlockName => "Text";
        public override int BlockIdentifier => 4;

        public SwiftBlock4()
        {
        }

        public SwiftBlock4(SwiftTagListBlock swiftTags) : base(swiftTags)
        {
        }

        public SwiftBlock4(string blockText)
        {
            SetValue(blockText);
        }

        public override void SetValue(string blockText)
        {
            SetBlockText(blockText);
        }

        public override string GetValue()
        {
            return GetBlockText();
        }

        public override bool Equals(object obj)
        {
            if (obj == null) { return false; }
            if (ReferenceEquals(this, obj)) { return true; }
            return obj is SwiftBlock4 block &&
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
