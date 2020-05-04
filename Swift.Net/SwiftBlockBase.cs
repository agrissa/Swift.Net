using System;
using System.Collections.Generic;
using System.Text;

namespace Swift.Net
{
    public abstract class SwiftBlockBase
    {
        public abstract string BlockName { get; }
        public abstract int BlockIdentifier { get; }

        public abstract void SetValue(string blockText);
        public abstract string GetValue();
    }
}
