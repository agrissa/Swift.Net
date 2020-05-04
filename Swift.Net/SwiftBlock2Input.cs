using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Swift.Net
{
    public class SwiftBlock2Input : SwiftBlock2
    {
        public string ReceiverAddress { get; set; }
        public string DeliveryMonitoring { get; set; }
        public string ObsolescencePeriod { get; set; }

        public SwiftBlock2Input()
        {
        }

        public SwiftBlock2Input(string blockText) : base()
        {
            SetValue(blockText);
        }

        public override string GetValue()
        {
            StringBuilder result = new StringBuilder("I");

            if (!string.IsNullOrEmpty(MessageType))
            {
                result.Append(MessageType);
            }
            if (!string.IsNullOrEmpty(ReceiverAddress))
            {
                result.Append(ReceiverAddress);
            }
            if (!string.IsNullOrEmpty(MessagePriority))
            {
                result.Append(MessagePriority);
            }
            if (!string.IsNullOrEmpty(DeliveryMonitoring))
            {
                result.Append(DeliveryMonitoring);
            }
            if (!string.IsNullOrEmpty(ObsolescencePeriod))
            {
                result.Append(ObsolescencePeriod);
            }

            return result.ToString();
        }

        public override void SetValue(string blockText)
        {
            if (blockText == null)
                throw new ArgumentNullException("blockText");

            Regex regex = new Regex(@"^(2:)?I\d{3}\w{12}([SUN]([1-3](\d{3})?)?)?$");
            if (!regex.IsMatch(blockText))
                throw new ArgumentException($"Invalid format");

            int offset = 0;
            if (blockText.StartsWith("2:"))
                offset += 2;

            Direction = Direction.Input;
            offset++;

            MessageType = blockText.Substring(offset, 3);
            offset += 3;

            ReceiverAddress = blockText.Substring(offset, 12);
            offset += 12;

            if (offset < blockText.Length)
            {
                MessagePriority = blockText.Substring(offset, 1);
                offset += 1;
            }


            if (offset < blockText.Length)
            {
                DeliveryMonitoring = blockText.Substring(offset, 1);
                offset += 1;
            }

            if (offset < blockText.Length)
            {
                ObsolescencePeriod = blockText.Substring(offset, 3);
            }
        }

        public override bool Equals(object obj)
        {
            if (obj == null) { return false; }
            if (ReferenceEquals(this, obj)) { return true; }
            return obj is SwiftBlock2Input input &&
                   base.Equals(obj) &&
                   ReceiverAddress == input.ReceiverAddress &&
                   DeliveryMonitoring == input.DeliveryMonitoring &&
                   ObsolescencePeriod == input.ObsolescencePeriod;
        }

        public override int GetHashCode()
        {
            int hashCode = 621231914;
            hashCode = hashCode * -1521134295 + base.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(ReceiverAddress);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(DeliveryMonitoring);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(ObsolescencePeriod);
            return hashCode;
        }

        public override string ToString()
        {
            return GetValue();
        }
    }
}
