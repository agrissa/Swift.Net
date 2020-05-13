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
    /// MT591 (SRG 2019)
    /// <summary>
    public partial class MT591 : SwiftMessage
    {
        
		public override SwiftBlock4 Block4 { get => new SwiftBlock4(GetBlock4Tags()); set => SetBlock4Tags(value); }

        /// <summary>
        /// Transaction Reference Number
        /// <summary>
		public string Tag20_TransactionReferenceNumber { get; set; }
        /// <summary>
        /// Related Reference
        /// <summary>
		public string Tag21_RelatedReference { get; set; }
        /// <summary>
        /// Currency Code, Amount
        /// <summary>
		public string Tag32B_CurrencyCodeAmount { get; set; }
        /// <summary>
        /// Ordering Institution
        /// <summary>
		public string Tag52A_OrderingInstitution { get; set; }
        /// <summary>
        /// Ordering Institution
        /// <summary>
		public string Tag52D_OrderingInstitution { get; set; }
        /// <summary>
        /// Account With Institution
        /// <summary>
		public string Tag57A_AccountWithInstitution { get; set; }
        /// <summary>
        /// Account With Institution
        /// <summary>
		public string Tag57B_AccountWithInstitution { get; set; }
        /// <summary>
        /// Account With Institution
        /// <summary>
		public string Tag57D_AccountWithInstitution { get; set; }
        /// <summary>
        /// Details Of Charges
        /// <summary>
		public string Tag71B_DetailsOfCharges { get; set; }
        /// <summary>
        /// Sender to Receiver Information
        /// <summary>
		public string Tag72_SenderToReceiverInformation { get; set; }
        
        public MT591()
        {
        }
        
        public MT591(SwiftTagList tags)
        {
			SetBlock4Tags(tags);
        }
        
        public virtual SwiftTagList GetBlock4Tags()
        {
			SwiftTagList tags = new SwiftTagList();
			if (Tag20_TransactionReferenceNumber != null)
				tags.Add(new SwiftTag("20", Tag20_TransactionReferenceNumber));
			if (Tag21_RelatedReference != null)
				tags.Add(new SwiftTag("21", Tag21_RelatedReference));
			if (Tag32B_CurrencyCodeAmount != null)
				tags.Add(new SwiftTag("32B", Tag32B_CurrencyCodeAmount));
			if (Tag52A_OrderingInstitution != null)
				tags.Add(new SwiftTag("52A", Tag52A_OrderingInstitution));
			if (Tag52D_OrderingInstitution != null)
				tags.Add(new SwiftTag("52D", Tag52D_OrderingInstitution));
			if (Tag57A_AccountWithInstitution != null)
				tags.Add(new SwiftTag("57A", Tag57A_AccountWithInstitution));
			if (Tag57B_AccountWithInstitution != null)
				tags.Add(new SwiftTag("57B", Tag57B_AccountWithInstitution));
			if (Tag57D_AccountWithInstitution != null)
				tags.Add(new SwiftTag("57D", Tag57D_AccountWithInstitution));
			if (Tag71B_DetailsOfCharges != null)
				tags.Add(new SwiftTag("71B", Tag71B_DetailsOfCharges));
			if (Tag72_SenderToReceiverInformation != null)
				tags.Add(new SwiftTag("72", Tag72_SenderToReceiverInformation));
			return tags;
        }
        
        public virtual void SetBlock4Tags(SwiftTagList tags)
        {
			int i = 0;
			foreach(SwiftTag tag in tags)
			{
				if ((tag.Name == "20") && (i <= 1))
				{
					Tag20_TransactionReferenceNumber = tag.Value;
					i = 1;
				}
				else if ((tag.Name == "21") && (i <= 2))
				{
					Tag21_RelatedReference = tag.Value;
					i = 2;
				}
				else if ((tag.Name == "32B") && (i <= 3))
				{
					Tag32B_CurrencyCodeAmount = tag.Value;
					i = 3;
				}
				else if ((tag.Name == "52A") && (i <= 4))
				{
					Tag52A_OrderingInstitution = tag.Value;
					i = 4;
				}
				else if ((tag.Name == "52D") && (i <= 4))
				{
					Tag52D_OrderingInstitution = tag.Value;
					i = 4;
				}
				else if ((tag.Name == "57A") && (i <= 5))
				{
					Tag57A_AccountWithInstitution = tag.Value;
					i = 5;
				}
				else if ((tag.Name == "57B") && (i <= 5))
				{
					Tag57B_AccountWithInstitution = tag.Value;
					i = 5;
				}
				else if ((tag.Name == "57D") && (i <= 5))
				{
					Tag57D_AccountWithInstitution = tag.Value;
					i = 5;
				}
				else if ((tag.Name == "71B") && (i <= 6))
				{
					Tag71B_DetailsOfCharges = tag.Value;
					i = 6;
				}
				else if ((tag.Name == "72") && (i <= 7))
				{
					Tag72_SenderToReceiverInformation = tag.Value;
					i = 7;
				}
			}
        }
        
        public static MT591 Parse(string message)
        {
			SwiftMessage swiftMessage = new SwiftParser().GetSwiftMessage(message);
			MT591 result = new MT591()
			{
				Block1 = swiftMessage.Block1,
				Block2 = swiftMessage.Block2,
				Block3 = swiftMessage.Block3,
				Block4 = swiftMessage.Block4,
				Block5 = swiftMessage.Block5,
			};
			return result;
        }
        
        public static string Write(MT591 message)
        {
			return new SwiftWriter().GetFinMessage(message);
        }
    }
}
