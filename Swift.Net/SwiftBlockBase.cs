namespace Swift.Net
{
    public interface SwiftBlockBase
    {
        public string BlockName { get; }
        public int BlockIdentifier { get; }

        public void SetValue(string blockText);
        public string GetValue();
    }
}
