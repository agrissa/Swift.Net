//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Swift.Net.Mt.Category5
{
    using System;
    using System.Collections.Generic;
    using System.Linq;


    /// <summary>
    /// MT598 (SRG 2019)
    /// <summary>
    public partial class MT598 : SwiftMessage
    {

        public override SwiftBlock4 Block4 { get => new SwiftBlock4(GetBlock4Tags()); set => SetBlock4Tags(value); }

        /// <summary>
        /// Transaction Reference Number
        /// <summary>
		public string Tag20_TransactionReferenceNumber { get; set; }
        /// <summary>
        /// Sub-Message Type
        /// <summary>
		public string Tag12_SubMessageType { get; set; }
        /// <summary>
        /// Proprietary Message
        /// <summary>
		public string Tag77E_ProprietaryMessage { get; set; }

        public MT598()
        {
        }

        public MT598(SwiftTagList tags)
        {
            SetBlock4Tags(tags);
        }

        public virtual SwiftTagList GetBlock4Tags()
        {
            SwiftTagList tags = new SwiftTagList();
            if (Tag20_TransactionReferenceNumber != null)
                tags.Add(new SwiftTag("20", Tag20_TransactionReferenceNumber));
            if (Tag12_SubMessageType != null)
                tags.Add(new SwiftTag("12", Tag12_SubMessageType));
            if (Tag77E_ProprietaryMessage != null)
                tags.Add(new SwiftTag("77E", Tag77E_ProprietaryMessage));
            return tags;
        }

        public virtual void SetBlock4Tags(SwiftTagList tags)
        {
            int i = 0;
            foreach (SwiftTag tag in tags)
            {
                if ((tag.Name == "20") && (i <= 1))
                {
                    Tag20_TransactionReferenceNumber = tag.Value;
                    i = 1;
                }
                else if ((tag.Name == "12") && (i <= 2))
                {
                    Tag12_SubMessageType = tag.Value;
                    i = 2;
                }
                else if ((tag.Name == "77E") && (i <= 3))
                {
                    Tag77E_ProprietaryMessage = tag.Value;
                    i = 3;
                }
            }
        }

        public static MT598 Parse(string message)
        {
            SwiftMessage swiftMessage = new SwiftParser().GetSwiftMessage(message);
            MT598 result = new MT598()
            {
                Block1 = swiftMessage.Block1,
                Block2 = swiftMessage.Block2,
                Block3 = swiftMessage.Block3,
                Block4 = swiftMessage.Block4,
                Block5 = swiftMessage.Block5,
            };
            return result;
        }

        public static string Write(MT598 message)
        {
            return new SwiftWriter().GetFinMessage(message);
        }
    }
}
