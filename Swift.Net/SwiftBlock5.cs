using System.Collections.Generic;

namespace Swift.Net
{
    public class SwiftBlock5 : SwiftTagList, SwiftBlockBase
    {
        public string BlockName => "Trailer";
        public int BlockIdentifier => 5;

        public SwiftBlock5()
        {
        }

        public SwiftBlock5(SwiftTagList swiftTags) : base(swiftTags)
        {
        }

        public SwiftBlock5(string blockText)
        {
            SetValue(blockText);
        }

        public void SetValue(string blockText)
        {
            SetBlockTags(blockText, BlockIdentifier);
        }

        public string GetValue()
        {
            return GetBlockTags();
        }

        public override bool Equals(object obj)
        {
            if (obj == null) { return false; }
            if (ReferenceEquals(this, obj)) { return true; }
            return obj is SwiftBlock5 block &&
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