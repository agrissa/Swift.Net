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
    /// MT509 (SRG 2019)
    /// <summary>
    public partial class MT509 : SwiftMessage
    {
        
		public override SwiftBlock4 Block4 { get => new SwiftBlock4(GetBlock4Tags()); set => SetBlock4Tags(value); }

        /// <summary>
        /// General Information
        /// <summary>
		public MT509_SequenceA SequenceA { get; set; }
        /// <summary>
        /// Trade Details
        /// <summary>
		public MT509_SequenceB SequenceB { get; set; }
        /// <summary>
        /// Additional Information
        /// <summary>
		public MT509_SequenceC SequenceC { get; set; }
        
        public MT509()
        {
        }
        
        public MT509(SwiftTagList tags)
        {
			SetBlock4Tags(tags);
        }
        
        public virtual SwiftTagList GetBlock4Tags()
        {
			SwiftTagList tags = new SwiftTagList();
			if (SequenceA != null)
				tags.AddRange(SequenceA.GetTags());
			if (SequenceB != null)
				tags.AddRange(SequenceB.GetTags());
			if (SequenceC != null)
				tags.AddRange(SequenceC.GetTags());
			return tags;
        }
        
        public virtual void SetBlock4Tags(SwiftTagList tags)
        {
			SequenceA = MT509_SequenceA.GetMT509_SequenceA(tags);
			SequenceB = MT509_SequenceB.GetMT509_SequenceB(tags);
			SequenceC = MT509_SequenceC.GetMT509_SequenceC(tags);
        }
        
        public static MT509 Parse(string message)
        {
			SwiftMessage swiftMessage = new SwiftParser().GetSwiftMessage(message);
			MT509 result = new MT509()
			{
				Block1 = swiftMessage.Block1,
				Block2 = swiftMessage.Block2,
				Block3 = swiftMessage.Block3,
				Block4 = swiftMessage.Block4,
				Block5 = swiftMessage.Block5,
			};
			return result;
        }
        
        public static string Write(MT509 message)
        {
			return new SwiftWriter().GetFinMessage(message);
        }
    }
    
    /// <summary>
    /// General Information
    /// <summary>
    public partial class MT509_SequenceA
    {
        
		public static readonly string Tag16R_StartOfBlock_Value = "GENL";
        /// <summary>
        /// Start Of block
        /// <summary>
		public string Tag16R_StartOfBlock { get; set; }
        /// <summary>
        /// Sender’s Reference
        /// <summary>
		public string Tag20C_Reference { get; set; }
        /// <summary>
        /// Function of the Message
        /// <summary>
		public string Tag23G_FunctionOfTheMessage { get; set; }
        /// <summary>
        /// Preparation Date Time
        /// <summary>
		public string Tag98A_Date { get; set; }
        /// <summary>
        /// Preparation Date Time
        /// <summary>
		public string Tag98C_DateTime { get; set; }
        /// <summary>
        /// Trade Date/Time
        /// <summary>
		public string Tag98E_DateTime { get; set; }
        /// <summary>
        /// Linkages
        /// <summary>
		public List<MT509_SequenceA1> SequenceA1List { get; set; }
        /// <summary>
        /// Status
        /// <summary>
		public List<MT509_SequenceA2> SequenceA2List { get; set; }
		public static readonly string Tag16S_EndOfBlock_Value = "GENL";
        /// <summary>
        /// End Of Block
        /// <summary>
		public string Tag16S_EndOfBlock { get; set; }
        
        public MT509_SequenceA()
        {
        }
        
        public MT509_SequenceA(SwiftTagList tags)
        {
			SetTags(tags);
        }
        
        public virtual SwiftTagList GetTags()
        {
			SwiftTagList tags = new SwiftTagList();
			if (Tag16R_StartOfBlock != null)
				tags.Add(new SwiftTag("16R", Tag16R_StartOfBlock));
			if (Tag20C_Reference != null)
				tags.Add(new SwiftTag("20C", Tag20C_Reference));
			if (Tag23G_FunctionOfTheMessage != null)
				tags.Add(new SwiftTag("23G", Tag23G_FunctionOfTheMessage));
			if (Tag98A_Date != null)
				tags.Add(new SwiftTag("98A", Tag98A_Date));
			if (Tag98C_DateTime != null)
				tags.Add(new SwiftTag("98C", Tag98C_DateTime));
			if (Tag98E_DateTime != null)
				tags.Add(new SwiftTag("98E", Tag98E_DateTime));
			if (SequenceA1List != null)
				tags.AddRange(SequenceA1List.SelectMany(x => x.GetTags()).ToList());
			if (SequenceA2List != null)
				tags.AddRange(SequenceA2List.SelectMany(x => x.GetTags()).ToList());
			if (Tag16S_EndOfBlock != null)
				tags.Add(new SwiftTag("16S", Tag16S_EndOfBlock));
			return tags;
        }
        
        public virtual void SetTags(SwiftTagList tags)
        {
			int i = 0;
			foreach(SwiftTag tag in tags)
			{
				if ((tag == new SwiftTag("16R", Tag16R_StartOfBlock_Value)) && (i <= 1))
				{
					Tag16R_StartOfBlock = tag.Value;
					i = 1;
				}
				else if ((tag.Name == "20C") && (i <= 2))
				{
					Tag20C_Reference = tag.Value;
					i = 2;
				}
				else if ((tag.Name == "23G") && (i <= 3))
				{
					Tag23G_FunctionOfTheMessage = tag.Value;
					i = 3;
				}
				else if ((tag.Name == "98A") && (i <= 4))
				{
					Tag98A_Date = tag.Value;
					i = 4;
				}
				else if ((tag.Name == "98C") && (i <= 4))
				{
					Tag98C_DateTime = tag.Value;
					i = 4;
				}
				else if ((tag.Name == "98E") && (i <= 4))
				{
					Tag98E_DateTime = tag.Value;
					i = 4;
				}
				else if ((tag == new SwiftTag("16S", Tag16S_EndOfBlock_Value)) && (i <= 5))
				{
					Tag16S_EndOfBlock = tag.Value;
					i = 5;
				}
			}
			SequenceA1List = MT509_SequenceA1.GetMT509_SequenceA1List(tags);
			SequenceA2List = MT509_SequenceA2.GetMT509_SequenceA2List(tags);
        }
        
        public static MT509_SequenceA GetMT509_SequenceA(SwiftTagList tags)
        {
			SwiftTagList subBlock = tags.GetSubBlock(new SwiftTag("16R", MT509_SequenceA.Tag16R_StartOfBlock_Value), new SwiftTag("16S", MT509_SequenceA.Tag16S_EndOfBlock_Value));
			return new MT509_SequenceA(subBlock);
        }
    }
    
    /// <summary>
    /// Linkages
    /// <summary>
    public partial class MT509_SequenceA1
    {
        
		public static readonly string Tag16R_StartOfBlock_Value = "LINK";
        /// <summary>
        /// Start Of Block
        /// <summary>
		public string Tag16R_StartOfBlock { get; set; }
        /// <summary>
        /// Linked Message
        /// <summary>
		public string Tag13A_NumberIdentification { get; set; }
        /// <summary>
        /// Linked Message
        /// <summary>
		public string Tag13B_NumberIdentification { get; set; }
        /// <summary>
        /// Reference
        /// <summary>
		public string Tag20C_Reference { get; set; }
        /// <summary>
        /// Reference
        /// <summary>
		public string Tag20U_Reference { get; set; }
		public static readonly string Tag16S_EndOfBlock_Value = "LINK";
        /// <summary>
        /// End of Block
        /// <summary>
		public string Tag16S_EndOfBlock { get; set; }
        
        public MT509_SequenceA1()
        {
        }
        
        public MT509_SequenceA1(SwiftTagList tags)
        {
			SetTags(tags);
        }
        
        public virtual SwiftTagList GetTags()
        {
			SwiftTagList tags = new SwiftTagList();
			if (Tag16R_StartOfBlock != null)
				tags.Add(new SwiftTag("16R", Tag16R_StartOfBlock));
			if (Tag13A_NumberIdentification != null)
				tags.Add(new SwiftTag("13A", Tag13A_NumberIdentification));
			if (Tag13B_NumberIdentification != null)
				tags.Add(new SwiftTag("13B", Tag13B_NumberIdentification));
			if (Tag20C_Reference != null)
				tags.Add(new SwiftTag("20C", Tag20C_Reference));
			if (Tag20U_Reference != null)
				tags.Add(new SwiftTag("20U", Tag20U_Reference));
			if (Tag16S_EndOfBlock != null)
				tags.Add(new SwiftTag("16S", Tag16S_EndOfBlock));
			return tags;
        }
        
        public virtual void SetTags(SwiftTagList tags)
        {
			int i = 0;
			foreach(SwiftTag tag in tags)
			{
				if ((tag == new SwiftTag("16R", Tag16R_StartOfBlock_Value)) && (i <= 1))
				{
					Tag16R_StartOfBlock = tag.Value;
					i = 1;
				}
				else if ((tag.Name == "13A") && (i <= 2))
				{
					Tag13A_NumberIdentification = tag.Value;
					i = 2;
				}
				else if ((tag.Name == "13B") && (i <= 2))
				{
					Tag13B_NumberIdentification = tag.Value;
					i = 2;
				}
				else if ((tag.Name == "20C") && (i <= 3))
				{
					Tag20C_Reference = tag.Value;
					i = 3;
				}
				else if ((tag.Name == "20U") && (i <= 3))
				{
					Tag20U_Reference = tag.Value;
					i = 3;
				}
				else if ((tag == new SwiftTag("16S", Tag16S_EndOfBlock_Value)) && (i <= 4))
				{
					Tag16S_EndOfBlock = tag.Value;
					i = 4;
				}
			}
        }
        
        public static List<MT509_SequenceA1> GetMT509_SequenceA1List(SwiftTagList tags)
        {
			List<MT509_SequenceA1> result = new List<MT509_SequenceA1>();
			List<SwiftTagList> subBlocks = tags.GetSubBlocks(new SwiftTag("16R", MT509_SequenceA1.Tag16R_StartOfBlock_Value), new SwiftTag("16S", MT509_SequenceA1.Tag16S_EndOfBlock_Value));
			foreach(var subBlock in subBlocks)
			{
				var subTags = subBlock.GetSubBlock(new SwiftTag("16R", MT509_SequenceA1.Tag16R_StartOfBlock_Value), new SwiftTag("16S", MT509_SequenceA1.Tag16S_EndOfBlock_Value));
				if (subTags.Count == 0) continue;
				MT509_SequenceA1 sequence = new MT509_SequenceA1(subTags);
				result.Add(sequence);
			}
			return result;
        }
    }
    
    /// <summary>
    /// Status
    /// <summary>
    public partial class MT509_SequenceA2
    {
        
		public static readonly string Tag16R_StartOfBlock_Value = "STAT";
        /// <summary>
        /// Start Of Block
        /// <summary>
		public string Tag16R_StartOfBlock { get; set; }
        /// <summary>
        /// Status Code
        /// <summary>
		public string Tag25D_StatusCode { get; set; }
        /// <summary>
        /// Reason
        /// <summary>
		public List<MT509_SequenceA2a> SequenceA2aList { get; set; }
		public static readonly string Tag16S_EndOfBlock_Value = "STAT";
        /// <summary>
        /// End Of Block
        /// <summary>
		public string Tag16S_EndOfBlock { get; set; }
        
        public MT509_SequenceA2()
        {
        }
        
        public MT509_SequenceA2(SwiftTagList tags)
        {
			SetTags(tags);
        }
        
        public virtual SwiftTagList GetTags()
        {
			SwiftTagList tags = new SwiftTagList();
			if (Tag16R_StartOfBlock != null)
				tags.Add(new SwiftTag("16R", Tag16R_StartOfBlock));
			if (Tag25D_StatusCode != null)
				tags.Add(new SwiftTag("25D", Tag25D_StatusCode));
			if (SequenceA2aList != null)
				tags.AddRange(SequenceA2aList.SelectMany(x => x.GetTags()).ToList());
			if (Tag16S_EndOfBlock != null)
				tags.Add(new SwiftTag("16S", Tag16S_EndOfBlock));
			return tags;
        }
        
        public virtual void SetTags(SwiftTagList tags)
        {
			int i = 0;
			foreach(SwiftTag tag in tags)
			{
				if ((tag == new SwiftTag("16R", Tag16R_StartOfBlock_Value)) && (i <= 1))
				{
					Tag16R_StartOfBlock = tag.Value;
					i = 1;
				}
				else if ((tag.Name == "25D") && (i <= 2))
				{
					Tag25D_StatusCode = tag.Value;
					i = 2;
				}
				else if ((tag == new SwiftTag("16S", Tag16S_EndOfBlock_Value)) && (i <= 3))
				{
					Tag16S_EndOfBlock = tag.Value;
					i = 3;
				}
			}
			SequenceA2aList = MT509_SequenceA2a.GetMT509_SequenceA2aList(tags);
        }
        
        public static List<MT509_SequenceA2> GetMT509_SequenceA2List(SwiftTagList tags)
        {
			List<MT509_SequenceA2> result = new List<MT509_SequenceA2>();
			List<SwiftTagList> subBlocks = tags.GetSubBlocks(new SwiftTag("16R", MT509_SequenceA2.Tag16R_StartOfBlock_Value), new SwiftTag("16S", MT509_SequenceA2.Tag16S_EndOfBlock_Value));
			foreach(var subBlock in subBlocks)
			{
				var subTags = subBlock.GetSubBlock(new SwiftTag("16R", MT509_SequenceA2.Tag16R_StartOfBlock_Value), new SwiftTag("16S", MT509_SequenceA2.Tag16S_EndOfBlock_Value));
				if (subTags.Count == 0) continue;
				MT509_SequenceA2 sequence = new MT509_SequenceA2(subTags);
				result.Add(sequence);
			}
			return result;
        }
    }
    
    /// <summary>
    /// Reason
    /// <summary>
    public partial class MT509_SequenceA2a
    {
        
		public static readonly string Tag16R_StartOfBlock_Value = "REAS";
        /// <summary>
        /// Start Of Block
        /// <summary>
		public string Tag16R_StartOfBlock { get; set; }
        /// <summary>
        /// Reason Code
        /// <summary>
		public string Tag24B_ReasonCode { get; set; }
        /// <summary>
        /// Reason Narrative
        /// <summary>
		public string Tag70D_Narrative { get; set; }
		public static readonly string Tag16S_EndOfBlock_Value = "REAS";
        /// <summary>
        /// End Of Block
        /// <summary>
		public string Tag16S_EndOfBlock { get; set; }
        
        public MT509_SequenceA2a()
        {
        }
        
        public MT509_SequenceA2a(SwiftTagList tags)
        {
			SetTags(tags);
        }
        
        public virtual SwiftTagList GetTags()
        {
			SwiftTagList tags = new SwiftTagList();
			if (Tag16R_StartOfBlock != null)
				tags.Add(new SwiftTag("16R", Tag16R_StartOfBlock));
			if (Tag24B_ReasonCode != null)
				tags.Add(new SwiftTag("24B", Tag24B_ReasonCode));
			if (Tag70D_Narrative != null)
				tags.Add(new SwiftTag("70D", Tag70D_Narrative));
			if (Tag16S_EndOfBlock != null)
				tags.Add(new SwiftTag("16S", Tag16S_EndOfBlock));
			return tags;
        }
        
        public virtual void SetTags(SwiftTagList tags)
        {
			int i = 0;
			foreach(SwiftTag tag in tags)
			{
				if ((tag == new SwiftTag("16R", Tag16R_StartOfBlock_Value)) && (i <= 1))
				{
					Tag16R_StartOfBlock = tag.Value;
					i = 1;
				}
				else if ((tag.Name == "24B") && (i <= 2))
				{
					Tag24B_ReasonCode = tag.Value;
					i = 2;
				}
				else if ((tag.Name == "70D") && (i <= 3))
				{
					Tag70D_Narrative = tag.Value;
					i = 3;
				}
				else if ((tag == new SwiftTag("16S", Tag16S_EndOfBlock_Value)) && (i <= 4))
				{
					Tag16S_EndOfBlock = tag.Value;
					i = 4;
				}
			}
        }
        
        public static List<MT509_SequenceA2a> GetMT509_SequenceA2aList(SwiftTagList tags)
        {
			List<MT509_SequenceA2a> result = new List<MT509_SequenceA2a>();
			List<SwiftTagList> subBlocks = tags.GetSubBlocks(new SwiftTag("16R", MT509_SequenceA2a.Tag16R_StartOfBlock_Value), new SwiftTag("16S", MT509_SequenceA2a.Tag16S_EndOfBlock_Value));
			foreach(var subBlock in subBlocks)
			{
				var subTags = subBlock.GetSubBlock(new SwiftTag("16R", MT509_SequenceA2a.Tag16R_StartOfBlock_Value), new SwiftTag("16S", MT509_SequenceA2a.Tag16S_EndOfBlock_Value));
				if (subTags.Count == 0) continue;
				MT509_SequenceA2a sequence = new MT509_SequenceA2a(subTags);
				result.Add(sequence);
			}
			return result;
        }
    }
    
    /// <summary>
    /// Trade Details
    /// <summary>
    public partial class MT509_SequenceB
    {
        
		public static readonly string Tag16R_StartOfBlock_Value = "TRADE";
        /// <summary>
        /// Start Of Block
        /// <summary>
		public string Tag16R_StartOfBlock { get; set; }
        /// <summary>
        /// Date/Time
        /// <summary>
		public List<string> Tag98A_Date { get; set; }
        /// <summary>
        /// Date/Time
        /// <summary>
		public List<string> Tag98B_DateCode { get; set; }
        /// <summary>
        /// Date/Time
        /// <summary>
		public List<string> Tag98C_DateTime { get; set; }
        /// <summary>
        /// Currency
        /// <summary>
		public string Tag11A_Currency { get; set; }
        /// <summary>
        /// Indicator
        /// <summary>
		public List<string> Tag22F_Indicator { get; set; }
        /// <summary>
        /// Indicator
        /// <summary>
		public List<string> Tag22H_Indicator { get; set; }
        /// <summary>
        /// Party
        /// <summary>
		public List<string> Tag95P_Party { get; set; }
        /// <summary>
        /// Party
        /// <summary>
		public List<string> Tag95R_Party { get; set; }
        /// <summary>
        /// Party
        /// <summary>
		public List<string> Tag95L_Party { get; set; }
        /// <summary>
        /// Account
        /// <summary>
		public string Tag97A_Account { get; set; }
        /// <summary>
        /// Safekeeping Account
        /// <summary>
		public string Tag97B_Account { get; set; }
        /// <summary>
        /// Trading Parties
        /// <summary>
		public List<MT509_SequenceB1> SequenceB1List { get; set; }
        /// <summary>
        /// Amount
        /// <summary>
		public List<string> Tag19A_Amount { get; set; }
        /// <summary>
        /// Deal Price 
        /// <summary>
		public List<string> Tag90A_Price { get; set; }
        /// <summary>
        /// Deal Price 
        /// <summary>
		public List<string> Tag90B_Price { get; set; }
        /// <summary>
        /// Quantity of Financial Instrument
        /// <summary>
		public List<string> Tag36B_QuantityOfFinancialInstrument { get; set; }
        /// <summary>
        /// Identification of the Financial Instrument
        /// <summary>
		public string Tag35B_IdentificationOfFinancialInstrument { get; set; }
		public static readonly string Tag16S_EndOfBlock_Value = "TRADE";
        /// <summary>
        /// End of Block
        /// <summary>
		public string Tag16S_EndOfBlock { get; set; }
        
        public MT509_SequenceB()
        {
        }
        
        public MT509_SequenceB(SwiftTagList tags)
        {
			SetTags(tags);
        }
        
        public virtual SwiftTagList GetTags()
        {
			SwiftTagList tags = new SwiftTagList();
			if (Tag16R_StartOfBlock != null)
				tags.Add(new SwiftTag("16R", Tag16R_StartOfBlock));
			if (Tag98A_Date != null)
				tags.AddRange(Tag98A_Date.Select(x => new SwiftTag("98A", x)).ToList());
			if (Tag98B_DateCode != null)
				tags.AddRange(Tag98B_DateCode.Select(x => new SwiftTag("98B", x)).ToList());
			if (Tag98C_DateTime != null)
				tags.AddRange(Tag98C_DateTime.Select(x => new SwiftTag("98C", x)).ToList());
			if (Tag11A_Currency != null)
				tags.Add(new SwiftTag("11A", Tag11A_Currency));
			if (Tag22F_Indicator != null)
				tags.AddRange(Tag22F_Indicator.Select(x => new SwiftTag("22F", x)).ToList());
			if (Tag22H_Indicator != null)
				tags.AddRange(Tag22H_Indicator.Select(x => new SwiftTag("22H", x)).ToList());
			if (Tag95P_Party != null)
				tags.AddRange(Tag95P_Party.Select(x => new SwiftTag("95P", x)).ToList());
			if (Tag95R_Party != null)
				tags.AddRange(Tag95R_Party.Select(x => new SwiftTag("95R", x)).ToList());
			if (Tag95L_Party != null)
				tags.AddRange(Tag95L_Party.Select(x => new SwiftTag("95L", x)).ToList());
			if (Tag97A_Account != null)
				tags.Add(new SwiftTag("97A", Tag97A_Account));
			if (Tag97B_Account != null)
				tags.Add(new SwiftTag("97B", Tag97B_Account));
			if (SequenceB1List != null)
				tags.AddRange(SequenceB1List.SelectMany(x => x.GetTags()).ToList());
			if (Tag19A_Amount != null)
				tags.AddRange(Tag19A_Amount.Select(x => new SwiftTag("19A", x)).ToList());
			if (Tag90A_Price != null)
				tags.AddRange(Tag90A_Price.Select(x => new SwiftTag("90A", x)).ToList());
			if (Tag90B_Price != null)
				tags.AddRange(Tag90B_Price.Select(x => new SwiftTag("90B", x)).ToList());
			if (Tag36B_QuantityOfFinancialInstrument != null)
				tags.AddRange(Tag36B_QuantityOfFinancialInstrument.Select(x => new SwiftTag("36B", x)).ToList());
			if (Tag35B_IdentificationOfFinancialInstrument != null)
				tags.Add(new SwiftTag("35B", Tag35B_IdentificationOfFinancialInstrument));
			if (Tag16S_EndOfBlock != null)
				tags.Add(new SwiftTag("16S", Tag16S_EndOfBlock));
			return tags;
        }
        
        public virtual void SetTags(SwiftTagList tags)
        {
			int i = 0;
			foreach(SwiftTag tag in tags)
			{
				if ((tag == new SwiftTag("16R", Tag16R_StartOfBlock_Value)) && (i <= 1))
				{
					Tag16R_StartOfBlock = tag.Value;
					i = 1;
				}
				else if ((tag.Name == "98A") && (i <= 2))
				{
					if (Tag98A_Date == null)
						Tag98A_Date = new List<string>();
					Tag98A_Date.Add(tag.Value);
					i = 2;
				}
				else if ((tag.Name == "98B") && (i <= 2))
				{
					if (Tag98B_DateCode == null)
						Tag98B_DateCode = new List<string>();
					Tag98B_DateCode.Add(tag.Value);
					i = 2;
				}
				else if ((tag.Name == "98C") && (i <= 2))
				{
					if (Tag98C_DateTime == null)
						Tag98C_DateTime = new List<string>();
					Tag98C_DateTime.Add(tag.Value);
					i = 2;
				}
				else if ((tag.Name == "11A") && (i <= 3))
				{
					Tag11A_Currency = tag.Value;
					i = 3;
				}
				else if ((tag.Name == "22F") && (i <= 4))
				{
					if (Tag22F_Indicator == null)
						Tag22F_Indicator = new List<string>();
					Tag22F_Indicator.Add(tag.Value);
					i = 4;
				}
				else if ((tag.Name == "22H") && (i <= 4))
				{
					if (Tag22H_Indicator == null)
						Tag22H_Indicator = new List<string>();
					Tag22H_Indicator.Add(tag.Value);
					i = 4;
				}
				else if ((tag.Name == "95P") && (i <= 5))
				{
					if (Tag95P_Party == null)
						Tag95P_Party = new List<string>();
					Tag95P_Party.Add(tag.Value);
					i = 5;
				}
				else if ((tag.Name == "95R") && (i <= 5))
				{
					if (Tag95R_Party == null)
						Tag95R_Party = new List<string>();
					Tag95R_Party.Add(tag.Value);
					i = 5;
				}
				else if ((tag.Name == "95L") && (i <= 5))
				{
					if (Tag95L_Party == null)
						Tag95L_Party = new List<string>();
					Tag95L_Party.Add(tag.Value);
					i = 5;
				}
				else if ((tag.Name == "97A") && (i <= 6))
				{
					Tag97A_Account = tag.Value;
					i = 6;
				}
				else if ((tag.Name == "97B") && (i <= 6))
				{
					Tag97B_Account = tag.Value;
					i = 6;
				}
				else if ((tag.Name == "19A") && (i <= 7))
				{
					if (Tag19A_Amount == null)
						Tag19A_Amount = new List<string>();
					Tag19A_Amount.Add(tag.Value);
					i = 7;
				}
				else if ((tag.Name == "90A") && (i <= 8))
				{
					if (Tag90A_Price == null)
						Tag90A_Price = new List<string>();
					Tag90A_Price.Add(tag.Value);
					i = 8;
				}
				else if ((tag.Name == "90B") && (i <= 8))
				{
					if (Tag90B_Price == null)
						Tag90B_Price = new List<string>();
					Tag90B_Price.Add(tag.Value);
					i = 8;
				}
				else if ((tag.Name == "36B") && (i <= 9))
				{
					if (Tag36B_QuantityOfFinancialInstrument == null)
						Tag36B_QuantityOfFinancialInstrument = new List<string>();
					Tag36B_QuantityOfFinancialInstrument.Add(tag.Value);
					i = 9;
				}
				else if ((tag.Name == "35B") && (i <= 10))
				{
					Tag35B_IdentificationOfFinancialInstrument = tag.Value;
					i = 10;
				}
				else if ((tag == new SwiftTag("16S", Tag16S_EndOfBlock_Value)) && (i <= 11))
				{
					Tag16S_EndOfBlock = tag.Value;
					i = 11;
				}
			}
			SequenceB1List = MT509_SequenceB1.GetMT509_SequenceB1List(tags);
        }
        
        public static MT509_SequenceB GetMT509_SequenceB(SwiftTagList tags)
        {
			SwiftTagList subBlock = tags.GetSubBlock(new SwiftTag("16R", MT509_SequenceB.Tag16R_StartOfBlock_Value), new SwiftTag("16S", MT509_SequenceB.Tag16S_EndOfBlock_Value));
			return new MT509_SequenceB(subBlock);
        }
    }
    
    /// <summary>
    /// Trading Parties
    /// <summary>
    public partial class MT509_SequenceB1
    {
        
		public static readonly string Tag16R_StartOfBlock_Value = "TRADPRTY";
        /// <summary>
        /// Start Of Block
        /// <summary>
		public string Tag16R_StartOfBlock { get; set; }
        /// <summary>
        /// Account Owner
        /// <summary>
		public List<string> Tag95P_Party { get; set; }
        /// <summary>
        /// Account Owner
        /// <summary>
		public List<string> Tag95Q_Party { get; set; }
        /// <summary>
        /// Account Owner
        /// <summary>
		public List<string> Tag95R_Party { get; set; }
        /// <summary>
        /// Account Owner
        /// <summary>
		public List<string> Tag95S_Party { get; set; }
        /// <summary>
        /// Party
        /// <summary>
		public List<string> Tag95L_Party { get; set; }
        /// <summary>
        /// Safekeeping Account
        /// <summary>
		public List<string> Tag97A_Account { get; set; }
        /// <summary>
        /// Account
        /// <summary>
		public List<string> Tag97B_Account { get; set; }
        /// <summary>
        /// Account
        /// <summary>
		public List<string> Tag97E_Account { get; set; }
        /// <summary>
        /// Preparation Date Time
        /// <summary>
		public string Tag98A_Date { get; set; }
        /// <summary>
        /// Preparation Date Time
        /// <summary>
		public string Tag98C_DateTime { get; set; }
        /// <summary>
        /// Processing Reference
        /// <summary>
		public string Tag20C_Reference { get; set; }
        /// <summary>
        /// Party Narrative
        /// <summary>
		public List<string> Tag70C_Narrative { get; set; }
        /// <summary>
        /// Declaration Details Narrative
        /// <summary>
		public List<string> Tag70E_Narrative { get; set; }
        /// <summary>
        /// Party Capacity Indicator 
        /// <summary>
		public List<string> Tag22F_Indicator { get; set; }
		public static readonly string Tag16S_EndOfBlock_Value = "TRADPRTY";
        /// <summary>
        /// End Of Block
        /// <summary>
		public string Tag16S_EndOfBlock { get; set; }
        
        public MT509_SequenceB1()
        {
        }
        
        public MT509_SequenceB1(SwiftTagList tags)
        {
			SetTags(tags);
        }
        
        public virtual SwiftTagList GetTags()
        {
			SwiftTagList tags = new SwiftTagList();
			if (Tag16R_StartOfBlock != null)
				tags.Add(new SwiftTag("16R", Tag16R_StartOfBlock));
			if (Tag95P_Party != null)
				tags.AddRange(Tag95P_Party.Select(x => new SwiftTag("95P", x)).ToList());
			if (Tag95Q_Party != null)
				tags.AddRange(Tag95Q_Party.Select(x => new SwiftTag("95Q", x)).ToList());
			if (Tag95R_Party != null)
				tags.AddRange(Tag95R_Party.Select(x => new SwiftTag("95R", x)).ToList());
			if (Tag95S_Party != null)
				tags.AddRange(Tag95S_Party.Select(x => new SwiftTag("95S", x)).ToList());
			if (Tag95L_Party != null)
				tags.AddRange(Tag95L_Party.Select(x => new SwiftTag("95L", x)).ToList());
			if (Tag97A_Account != null)
				tags.AddRange(Tag97A_Account.Select(x => new SwiftTag("97A", x)).ToList());
			if (Tag97B_Account != null)
				tags.AddRange(Tag97B_Account.Select(x => new SwiftTag("97B", x)).ToList());
			if (Tag97E_Account != null)
				tags.AddRange(Tag97E_Account.Select(x => new SwiftTag("97E", x)).ToList());
			if (Tag98A_Date != null)
				tags.Add(new SwiftTag("98A", Tag98A_Date));
			if (Tag98C_DateTime != null)
				tags.Add(new SwiftTag("98C", Tag98C_DateTime));
			if (Tag20C_Reference != null)
				tags.Add(new SwiftTag("20C", Tag20C_Reference));
			if (Tag70C_Narrative != null)
				tags.AddRange(Tag70C_Narrative.Select(x => new SwiftTag("70C", x)).ToList());
			if (Tag70E_Narrative != null)
				tags.AddRange(Tag70E_Narrative.Select(x => new SwiftTag("70E", x)).ToList());
			if (Tag22F_Indicator != null)
				tags.AddRange(Tag22F_Indicator.Select(x => new SwiftTag("22F", x)).ToList());
			if (Tag16S_EndOfBlock != null)
				tags.Add(new SwiftTag("16S", Tag16S_EndOfBlock));
			return tags;
        }
        
        public virtual void SetTags(SwiftTagList tags)
        {
			int i = 0;
			foreach(SwiftTag tag in tags)
			{
				if ((tag == new SwiftTag("16R", Tag16R_StartOfBlock_Value)) && (i <= 1))
				{
					Tag16R_StartOfBlock = tag.Value;
					i = 1;
				}
				else if ((tag.Name == "95P") && (i <= 2))
				{
					if (Tag95P_Party == null)
						Tag95P_Party = new List<string>();
					Tag95P_Party.Add(tag.Value);
					i = 2;
				}
				else if ((tag.Name == "95Q") && (i <= 2))
				{
					if (Tag95Q_Party == null)
						Tag95Q_Party = new List<string>();
					Tag95Q_Party.Add(tag.Value);
					i = 2;
				}
				else if ((tag.Name == "95R") && (i <= 2))
				{
					if (Tag95R_Party == null)
						Tag95R_Party = new List<string>();
					Tag95R_Party.Add(tag.Value);
					i = 2;
				}
				else if ((tag.Name == "95S") && (i <= 2))
				{
					if (Tag95S_Party == null)
						Tag95S_Party = new List<string>();
					Tag95S_Party.Add(tag.Value);
					i = 2;
				}
				else if ((tag.Name == "95L") && (i <= 2))
				{
					if (Tag95L_Party == null)
						Tag95L_Party = new List<string>();
					Tag95L_Party.Add(tag.Value);
					i = 2;
				}
				else if ((tag.Name == "97A") && (i <= 3))
				{
					if (Tag97A_Account == null)
						Tag97A_Account = new List<string>();
					Tag97A_Account.Add(tag.Value);
					i = 3;
				}
				else if ((tag.Name == "97B") && (i <= 3))
				{
					if (Tag97B_Account == null)
						Tag97B_Account = new List<string>();
					Tag97B_Account.Add(tag.Value);
					i = 3;
				}
				else if ((tag.Name == "97E") && (i <= 3))
				{
					if (Tag97E_Account == null)
						Tag97E_Account = new List<string>();
					Tag97E_Account.Add(tag.Value);
					i = 3;
				}
				else if ((tag.Name == "98A") && (i <= 4))
				{
					Tag98A_Date = tag.Value;
					i = 4;
				}
				else if ((tag.Name == "98C") && (i <= 4))
				{
					Tag98C_DateTime = tag.Value;
					i = 4;
				}
				else if ((tag.Name == "20C") && (i <= 5))
				{
					Tag20C_Reference = tag.Value;
					i = 5;
				}
				else if ((tag.Name == "70C") && (i <= 6))
				{
					if (Tag70C_Narrative == null)
						Tag70C_Narrative = new List<string>();
					Tag70C_Narrative.Add(tag.Value);
					i = 6;
				}
				else if ((tag.Name == "70E") && (i <= 6))
				{
					if (Tag70E_Narrative == null)
						Tag70E_Narrative = new List<string>();
					Tag70E_Narrative.Add(tag.Value);
					i = 6;
				}
				else if ((tag.Name == "22F") && (i <= 7))
				{
					if (Tag22F_Indicator == null)
						Tag22F_Indicator = new List<string>();
					Tag22F_Indicator.Add(tag.Value);
					i = 7;
				}
				else if ((tag == new SwiftTag("16S", Tag16S_EndOfBlock_Value)) && (i <= 8))
				{
					Tag16S_EndOfBlock = tag.Value;
					i = 8;
				}
			}
        }
        
        public static List<MT509_SequenceB1> GetMT509_SequenceB1List(SwiftTagList tags)
        {
			List<MT509_SequenceB1> result = new List<MT509_SequenceB1>();
			List<SwiftTagList> subBlocks = tags.GetSubBlocks(new SwiftTag("16R", MT509_SequenceB1.Tag16R_StartOfBlock_Value), new SwiftTag("16S", MT509_SequenceB1.Tag16S_EndOfBlock_Value));
			foreach(var subBlock in subBlocks)
			{
				var subTags = subBlock.GetSubBlock(new SwiftTag("16R", MT509_SequenceB1.Tag16R_StartOfBlock_Value), new SwiftTag("16S", MT509_SequenceB1.Tag16S_EndOfBlock_Value));
				if (subTags.Count == 0) continue;
				MT509_SequenceB1 sequence = new MT509_SequenceB1(subTags);
				result.Add(sequence);
			}
			return result;
        }
    }
    
    /// <summary>
    /// Additional Information
    /// <summary>
    public partial class MT509_SequenceC
    {
        
		public static readonly string Tag16R_StartOfBlock_Value = "ADDINFO";
        /// <summary>
        /// Start of Block
        /// <summary>
		public string Tag16R_StartOfBlock { get; set; }
        /// <summary>
        /// Party
        /// <summary>
		public List<string> Tag95P_Party { get; set; }
        /// <summary>
        /// Party
        /// <summary>
		public List<string> Tag95R_Party { get; set; }
        /// <summary>
        /// Party
        /// <summary>
		public List<string> Tag95Q_Party { get; set; }
		public static readonly string Tag16S_EndOfBlock_Value = "ADDINFO";
        /// <summary>
        /// End of Block
        /// <summary>
		public string Tag16S_EndOfBlock { get; set; }
        
        public MT509_SequenceC()
        {
        }
        
        public MT509_SequenceC(SwiftTagList tags)
        {
			SetTags(tags);
        }
        
        public virtual SwiftTagList GetTags()
        {
			SwiftTagList tags = new SwiftTagList();
			if (Tag16R_StartOfBlock != null)
				tags.Add(new SwiftTag("16R", Tag16R_StartOfBlock));
			if (Tag95P_Party != null)
				tags.AddRange(Tag95P_Party.Select(x => new SwiftTag("95P", x)).ToList());
			if (Tag95R_Party != null)
				tags.AddRange(Tag95R_Party.Select(x => new SwiftTag("95R", x)).ToList());
			if (Tag95Q_Party != null)
				tags.AddRange(Tag95Q_Party.Select(x => new SwiftTag("95Q", x)).ToList());
			if (Tag16S_EndOfBlock != null)
				tags.Add(new SwiftTag("16S", Tag16S_EndOfBlock));
			return tags;
        }
        
        public virtual void SetTags(SwiftTagList tags)
        {
			int i = 0;
			foreach(SwiftTag tag in tags)
			{
				if ((tag == new SwiftTag("16R", Tag16R_StartOfBlock_Value)) && (i <= 1))
				{
					Tag16R_StartOfBlock = tag.Value;
					i = 1;
				}
				else if ((tag.Name == "95P") && (i <= 2))
				{
					if (Tag95P_Party == null)
						Tag95P_Party = new List<string>();
					Tag95P_Party.Add(tag.Value);
					i = 2;
				}
				else if ((tag.Name == "95R") && (i <= 2))
				{
					if (Tag95R_Party == null)
						Tag95R_Party = new List<string>();
					Tag95R_Party.Add(tag.Value);
					i = 2;
				}
				else if ((tag.Name == "95Q") && (i <= 2))
				{
					if (Tag95Q_Party == null)
						Tag95Q_Party = new List<string>();
					Tag95Q_Party.Add(tag.Value);
					i = 2;
				}
				else if ((tag == new SwiftTag("16S", Tag16S_EndOfBlock_Value)) && (i <= 3))
				{
					Tag16S_EndOfBlock = tag.Value;
					i = 3;
				}
			}
        }
        
        public static MT509_SequenceC GetMT509_SequenceC(SwiftTagList tags)
        {
			SwiftTagList subBlock = tags.GetSubBlock(new SwiftTag("16R", MT509_SequenceC.Tag16R_StartOfBlock_Value), new SwiftTag("16S", MT509_SequenceC.Tag16S_EndOfBlock_Value));
			return new MT509_SequenceC(subBlock);
        }
    }
}