﻿using System;
using System.Collections.Generic;

namespace Swift.Net
{
    public class SwiftTag : IEquatable<SwiftTag>
    {
        public string Name { get; set; }
        public string Value { get; set; }
        public string LetterOption => throw new NotImplementedException();
        public int NameAsInt => throw new NotImplementedException();

        public SwiftTag(string tagText)
        {
            if (tagText == null)
                throw new ArgumentNullException("tagText");

            int i = tagText.IndexOf(':');
            if (i >= 0)
            {
                if (i > 0)
                {
                    Name = tagText.Substring(0, i);
                }
                if (i + 1 < tagText.Length)
                {
                    Value = tagText.Substring(i + 1);
                }
            }
            else
            {
                Value = tagText;
            }
        }

        public SwiftTag(string name, string value)
        {
            if (name == null)
                throw new ArgumentNullException("name");
            if (value == null)
                throw new ArgumentNullException("value");

            this.Name = name;
            this.Value = value;
        }

        public override bool Equals(object obj)
        {
            return Equals(obj as SwiftTag);
        }

        public bool Equals(SwiftTag tag)
        {
            if (tag == null) { return false; }
            if (ReferenceEquals(this, tag)) { return true; }
            return Name == tag.Name &&
                   Value == tag.Value;
        }

        public override int GetHashCode()
        {
            int hashCode = -1205067161;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Name);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Value);
            return hashCode;
        }

        public override string ToString()
        {
            return $"{Name}:{Value}";
        }
    }
}