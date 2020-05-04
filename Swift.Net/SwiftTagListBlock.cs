using Swift.Net.Exceptions;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Swift.Net
{
    public abstract class SwiftTagListBlock : SwiftBlockBase, IEnumerable<SwiftTag>, IList<SwiftTag>
    {
        private readonly List<SwiftTag> Tags;

        public SwiftTagListBlock()
        {
            Tags = new List<SwiftTag>();
        }

        public SwiftTagListBlock(SwiftTagListBlock swiftTags) : base()
        {
            Tags.AddRange(swiftTags);
        }

        public SwiftTag this[int index] { get => Tags[index]; set => Tags[index] = value; }

        public int Count => Tags.Count;

        public bool IsReadOnly => ((IList<SwiftTag>)Tags).IsReadOnly;

        public void Add(SwiftTag item)
        {
            Tags.Add(item);
        }

        public void Clear()
        {
            Tags.Clear();
        }

        public bool Contains(SwiftTag item)
        {
            return Tags.Contains(item);
        }

        public void CopyTo(SwiftTag[] array, int arrayIndex)
        {
            Tags.CopyTo(array, arrayIndex);
        }

        public IEnumerator<SwiftTag> GetEnumerator()
        {
            return ((IList<SwiftTag>)Tags).GetEnumerator();
        }

        public int IndexOf(SwiftTag item)
        {
            return Tags.IndexOf(item);
        }

        public void Insert(int index, SwiftTag item)
        {
            Tags.Insert(index, item);
        }

        public bool Remove(SwiftTag item)
        {
            return Tags.Remove(item);
        }

        public void RemoveAt(int index)
        {
            Tags.RemoveAt(index);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IList<SwiftTag>)Tags).GetEnumerator();
        }

        public override bool Equals(object obj)
        {
            if (obj == null) { return false; }
            if (ReferenceEquals(this, obj)) { return true; }
            return obj is SwiftTagListBlock block &&
                Enumerable.SequenceEqual<SwiftTag>(Tags, block.Tags);
        }

        public override int GetHashCode()
        {
            return 444497600 + EqualityComparer<List<SwiftTag>>.Default.GetHashCode(Tags);
        }

        protected void SetBlockTags(string blockText)
        {
            int i = 0;
            if (blockText.StartsWith(BlockIdentifier + ":"))
                i += 2;
            for (; i < blockText.Length; i++)
            {
                char c = blockText[i];
                if (IsBlockStart(c))
                {
                    int end = blockText.IndexOf("}", i);
                    if (end >= 0)
                    {
                        string tagText = blockText.Substring(i + 1, end - i - 1);
                        SwiftTag tag = new SwiftTag(tagText);
                        Tags.Add(tag);
                        i = end;
                        continue;
                    }
                }
                throw new SwiftParserException($"Unparsed text in block {BlockIdentifier}");
            }
        }

        protected void SetBlockText(string blockText)
        {
            if (!IsBlockTextEnd(blockText, blockText.Length - 1))
                throw new SwiftParserException($"The block {BlockIdentifier} must end with -}}");

            //Another solution with Regex/Groups :([0-9]{2}[A-Z])(:)(.*(?:\r?\n)?(?:(?!:[0-9]{2}[A-Z]:).*(?:\r?\n)?)*)
            //foreach (Match item in regex.Matches(text))
            //    block4.Add(new SwiftTag(item.Groups[1], item.Groups[3]));

            int i = 0;
            if (blockText.StartsWith("4:"))
                i += 2;
            for (; i < blockText.Length; i++)
            {
                char c = blockText[i];
                if (IsBlockTextTagStart(blockText, i))
                {
                    int end = GetNextBlockTextTag(blockText, i);
                    if (end >= 0)
                    {
                        string tagText = blockText.Substring(i + 1, end - i - 1);
                        SwiftTag tag = new SwiftTag(tagText);
                        Tags.Add(tag);
                        i = end;
                        continue;
                    }
                }
                else if ((c == '\r') || (c == '\n'))
                    continue;
                else if (IsBlockTextEnd(blockText, i))
                    continue;
                throw new SwiftParserException($"Unparsed text in block {BlockIdentifier}");
            }
        }

        protected string GetBlockTags()
        {
            if (Tags == null)
                return string.Empty;
            return string.Join("", Tags.Select(x => $"{{{x}}}"));
        }

        protected string GetBlockText()
        {
            if (Tags == null)
                return string.Empty;
            return string.Join("\r\n", Tags.Select(x => $":{x}"));
        }

        #region Privates

        private int GetNextBlockTextTag(string blockText, int startIndex)
        {
            for (int i = startIndex; i < blockText.Length; i++)
            {
                char c = blockText[i];
                if (c == '\n')
                {
                    if (IsBlockTextTagStart(blockText, i + 1))
                    {
                        return ((i - 1) >= startIndex) && (blockText[i - 1] == '\r') ? i - 1 : i;
                    }
                }
                else if (IsBlockTextEnd(blockText, i))
                {
                    int offset = 0;
                    if ((i - 1 >= startIndex) && (blockText[i - 1] == '\n'))
                        offset++;
                    if ((i - 2 >= startIndex) && (blockText[i - 2] == '\r'))
                        offset++;
                    return i - offset;
                }
            }
            return -1;
        }

        private bool IsBlockTextTagStart(string blockText, int index)
        {
            if ((index + 3 < blockText.Length) && (blockText[index] == ':') && char.IsDigit(blockText[index + 1]) && char.IsDigit(blockText[index + 2]))
            {
                char c4 = blockText[index + 3];
                if (c4 == ':')
                {
                    return true;
                }
                else if (char.IsUpper(c4) && (index + 4 < blockText.Length) && (blockText[index + 4] == ':'))
                {
                    return true;
                }
            }
            return false;
        }

        private bool IsBlockStart(char c)
        {
            return (c == '{') ? true : false;
        }

        private bool IsBlockEnd(char c)
        {
            return (c == '}') ? true : false;
        }

        private bool IsBlockTextEnd(string blockText, int index)
        {
            return (index + 1 == blockText.Length) && (blockText[index] == '-');
        }

        #endregion
    }
}