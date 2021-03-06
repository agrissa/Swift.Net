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
    /// MT568 (SRG 2019)
    /// <summary>
    public partial class MT568 : SwiftMessage
    {

        public override SwiftBlock4 Block4 { get => new SwiftBlock4(GetBlock4Tags()); set => SetBlock4Tags(value); }

        /// <summary>
        /// General Information
        /// <summary>
		public MT568_SequenceA SequenceA { get; set; }
        /// <summary>
        /// Underlying Securities
        /// <summary>
		public MT568_SequenceB SequenceB { get; set; }
        /// <summary>
        /// Additional Information
        /// <summary>
		public MT568_SequenceC SequenceC { get; set; }

        public MT568()
        {
        }

        public MT568(SwiftTagList tags)
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
            SequenceA = MT568_SequenceA.GetMT568_SequenceA(tags);
            SequenceB = MT568_SequenceB.GetMT568_SequenceB(tags);
            SequenceC = MT568_SequenceC.GetMT568_SequenceC(tags);
        }

        public static MT568 Parse(string message)
        {
            SwiftMessage swiftMessage = new SwiftParser().GetSwiftMessage(message);
            MT568 result = new MT568()
            {
                Block1 = swiftMessage.Block1,
                Block2 = swiftMessage.Block2,
                Block3 = swiftMessage.Block3,
                Block4 = swiftMessage.Block4,
                Block5 = swiftMessage.Block5,
            };
            return result;
        }

        public static string Write(MT568 message)
        {
            return new SwiftWriter().GetFinMessage(message);
        }
    }

    /// <summary>
    /// General Information
    /// <summary>
    public partial class MT568_SequenceA
    {

        public static readonly string Tag16R_StartOfBlock_Value = "GENL";
        /// <summary>
        /// Start Of Block
        /// <summary>
		public string Tag16R_StartOfBlock { get; set; }
        /// <summary>
        /// Page Number/Continuation Indicator
        /// <summary>
		public string Tag28E_PageNumberContinuationIndicator { get; set; }
        /// <summary>
        /// Reference
        /// <summary>
		public List<string> Tag20C_Reference { get; set; }
        /// <summary>
        /// Function of the Message
        /// <summary>
		public string Tag23G_FunctionOfTheMessage { get; set; }
        /// <summary>
        /// Corporate Action Event Indicator
        /// <summary>
		public string Tag22F_Indicator { get; set; }
        /// <summary>
        /// Preparation Date
        /// <summary>
		public string Tag98A_Date { get; set; }
        /// <summary>
        /// Preparation Date/Time
        /// <summary>
		public string Tag98C_DateTime { get; set; }
        /// <summary>
        /// Linkages
        /// <summary>
		public List<MT568_SequenceA1> SequenceA1List { get; set; }
        public static readonly string Tag16S_EndOfBlock_Value = "GENL";
        /// <summary>
        /// End Of Block
        /// <summary>
		public string Tag16S_EndOfBlock { get; set; }

        public MT568_SequenceA()
        {
        }

        public MT568_SequenceA(SwiftTagList tags)
        {
            SetTags(tags);
        }

        public virtual SwiftTagList GetTags()
        {
            SwiftTagList tags = new SwiftTagList();
            if (Tag16R_StartOfBlock != null)
                tags.Add(new SwiftTag("16R", Tag16R_StartOfBlock));
            if (Tag28E_PageNumberContinuationIndicator != null)
                tags.Add(new SwiftTag("28E", Tag28E_PageNumberContinuationIndicator));
            if (Tag20C_Reference != null)
                tags.AddRange(Tag20C_Reference.Select(x => new SwiftTag("20C", x)).ToList());
            if (Tag23G_FunctionOfTheMessage != null)
                tags.Add(new SwiftTag("23G", Tag23G_FunctionOfTheMessage));
            if (Tag22F_Indicator != null)
                tags.Add(new SwiftTag("22F", Tag22F_Indicator));
            if (Tag98A_Date != null)
                tags.Add(new SwiftTag("98A", Tag98A_Date));
            if (Tag98C_DateTime != null)
                tags.Add(new SwiftTag("98C", Tag98C_DateTime));
            if (SequenceA1List != null)
                tags.AddRange(SequenceA1List.SelectMany(x => x.GetTags()).ToList());
            if (Tag16S_EndOfBlock != null)
                tags.Add(new SwiftTag("16S", Tag16S_EndOfBlock));
            return tags;
        }

        public virtual void SetTags(SwiftTagList tags)
        {
            int i = 0;
            foreach (SwiftTag tag in tags)
            {
                if ((tag == new SwiftTag("16R", Tag16R_StartOfBlock_Value)) && (i <= 1))
                {
                    Tag16R_StartOfBlock = tag.Value;
                    i = 1;
                }
                else if ((tag.Name == "28E") && (i <= 2))
                {
                    Tag28E_PageNumberContinuationIndicator = tag.Value;
                    i = 2;
                }
                else if ((tag.Name == "20C") && (i <= 3))
                {
                    if (Tag20C_Reference == null)
                        Tag20C_Reference = new List<string>();
                    Tag20C_Reference.Add(tag.Value);
                    i = 3;
                }
                else if ((tag.Name == "23G") && (i <= 4))
                {
                    Tag23G_FunctionOfTheMessage = tag.Value;
                    i = 4;
                }
                else if ((tag.Name == "22F") && (i <= 5))
                {
                    Tag22F_Indicator = tag.Value;
                    i = 5;
                }
                else if ((tag.Name == "98A") && (i <= 6))
                {
                    Tag98A_Date = tag.Value;
                    i = 6;
                }
                else if ((tag.Name == "98C") && (i <= 6))
                {
                    Tag98C_DateTime = tag.Value;
                    i = 6;
                }
                else if ((tag == new SwiftTag("16S", Tag16S_EndOfBlock_Value)) && (i <= 7))
                {
                    Tag16S_EndOfBlock = tag.Value;
                    i = 7;
                }
            }
            SequenceA1List = MT568_SequenceA1.GetMT568_SequenceA1List(tags);
        }

        public static MT568_SequenceA GetMT568_SequenceA(SwiftTagList tags)
        {
            SwiftTagList subBlock = tags.GetSubBlock(new SwiftTag("16R", MT568_SequenceA.Tag16R_StartOfBlock_Value), new SwiftTag("16S", MT568_SequenceA.Tag16S_EndOfBlock_Value));
            return new MT568_SequenceA(subBlock);
        }
    }

    /// <summary>
    /// Linkages
    /// <summary>
    public partial class MT568_SequenceA1
    {

        public static readonly string Tag16R_StartOfBlock_Value = "LINK";
        /// <summary>
        /// Start Of Block
        /// <summary>
		public string Tag16R_StartOfBlock { get; set; }
        /// <summary>
        /// Linkage Type Indicator
        /// <summary>
		public string Tag22F_Indicator { get; set; }
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
        public static readonly string Tag16S_EndOfBlock_Value = "LINK";
        /// <summary>
        /// End Of Block
        /// <summary>
		public string Tag16S_EndOfBlock { get; set; }

        public MT568_SequenceA1()
        {
        }

        public MT568_SequenceA1(SwiftTagList tags)
        {
            SetTags(tags);
        }

        public virtual SwiftTagList GetTags()
        {
            SwiftTagList tags = new SwiftTagList();
            if (Tag16R_StartOfBlock != null)
                tags.Add(new SwiftTag("16R", Tag16R_StartOfBlock));
            if (Tag22F_Indicator != null)
                tags.Add(new SwiftTag("22F", Tag22F_Indicator));
            if (Tag13A_NumberIdentification != null)
                tags.Add(new SwiftTag("13A", Tag13A_NumberIdentification));
            if (Tag13B_NumberIdentification != null)
                tags.Add(new SwiftTag("13B", Tag13B_NumberIdentification));
            if (Tag20C_Reference != null)
                tags.Add(new SwiftTag("20C", Tag20C_Reference));
            if (Tag16S_EndOfBlock != null)
                tags.Add(new SwiftTag("16S", Tag16S_EndOfBlock));
            return tags;
        }

        public virtual void SetTags(SwiftTagList tags)
        {
            int i = 0;
            foreach (SwiftTag tag in tags)
            {
                if ((tag == new SwiftTag("16R", Tag16R_StartOfBlock_Value)) && (i <= 1))
                {
                    Tag16R_StartOfBlock = tag.Value;
                    i = 1;
                }
                else if ((tag.Name == "22F") && (i <= 2))
                {
                    Tag22F_Indicator = tag.Value;
                    i = 2;
                }
                else if ((tag.Name == "13A") && (i <= 3))
                {
                    Tag13A_NumberIdentification = tag.Value;
                    i = 3;
                }
                else if ((tag.Name == "13B") && (i <= 3))
                {
                    Tag13B_NumberIdentification = tag.Value;
                    i = 3;
                }
                else if ((tag.Name == "20C") && (i <= 4))
                {
                    Tag20C_Reference = tag.Value;
                    i = 4;
                }
                else if ((tag == new SwiftTag("16S", Tag16S_EndOfBlock_Value)) && (i <= 5))
                {
                    Tag16S_EndOfBlock = tag.Value;
                    i = 5;
                }
            }
        }

        public static List<MT568_SequenceA1> GetMT568_SequenceA1List(SwiftTagList tags)
        {
            List<MT568_SequenceA1> result = new List<MT568_SequenceA1>();
            List<SwiftTagList> subBlocks = tags.GetSubBlocks(new SwiftTag("16R", MT568_SequenceA1.Tag16R_StartOfBlock_Value), new SwiftTag("16S", MT568_SequenceA1.Tag16S_EndOfBlock_Value));
            foreach (var subBlock in subBlocks)
            {
                var subTags = subBlock.GetSubBlock(new SwiftTag("16R", MT568_SequenceA1.Tag16R_StartOfBlock_Value), new SwiftTag("16S", MT568_SequenceA1.Tag16S_EndOfBlock_Value));
                if (subTags.Count == 0) continue;
                MT568_SequenceA1 sequence = new MT568_SequenceA1(subTags);
                result.Add(sequence);
            }
            return result;
        }
    }

    /// <summary>
    /// Underlying Securities
    /// <summary>
    public partial class MT568_SequenceB
    {

        public static readonly string Tag16R_StartOfBlock_Value = "USECU";
        /// <summary>
        /// Start Of Block
        /// <summary>
		public string Tag16R_StartOfBlock { get; set; }
        /// <summary>
        /// Party
        /// <summary>
		public string Tag95P_Party { get; set; }
        /// <summary>
        /// Party
        /// <summary>
		public string Tag95R_Party { get; set; }
        /// <summary>
        /// Safekeeping Account
        /// <summary>
		public string Tag97A_Account { get; set; }
        /// <summary>
        /// Safe Keeping Account
        /// <summary>
		public string Tag97C_Account { get; set; }
        /// <summary>
        /// Place of Safekeeping
        /// <summary>
		public string Tag94B_Place { get; set; }
        /// <summary>
        /// Place of Safekeeping
        /// <summary>
		public string Tag94C_Place { get; set; }
        /// <summary>
        /// Place of Safekeeping
        /// <summary>
		public string Tag94F_Place { get; set; }
        /// <summary>
        /// Identification of the Financial Instrument
        /// <summary>
		public string Tag35B_IdentificationOfFinancialInstrument { get; set; }
        /// <summary>
        /// Financial Instrument Attributes
        /// <summary>
		public MT568_SequenceB1 SequenceB1 { get; set; }
        /// <summary>
        /// Balance
        /// <summary>
		public List<string> Tag93B_Balance { get; set; }
        /// <summary>
        /// Balance
        /// <summary>
		public List<string> Tag93C_Balance { get; set; }
        public static readonly string Tag16S_EndOfBlock_Value = "USECU";
        /// <summary>
        /// End Of Block
        /// <summary>
		public string Tag16S_EndOfBlock { get; set; }

        public MT568_SequenceB()
        {
        }

        public MT568_SequenceB(SwiftTagList tags)
        {
            SetTags(tags);
        }

        public virtual SwiftTagList GetTags()
        {
            SwiftTagList tags = new SwiftTagList();
            if (Tag16R_StartOfBlock != null)
                tags.Add(new SwiftTag("16R", Tag16R_StartOfBlock));
            if (Tag95P_Party != null)
                tags.Add(new SwiftTag("95P", Tag95P_Party));
            if (Tag95R_Party != null)
                tags.Add(new SwiftTag("95R", Tag95R_Party));
            if (Tag97A_Account != null)
                tags.Add(new SwiftTag("97A", Tag97A_Account));
            if (Tag97C_Account != null)
                tags.Add(new SwiftTag("97C", Tag97C_Account));
            if (Tag94B_Place != null)
                tags.Add(new SwiftTag("94B", Tag94B_Place));
            if (Tag94C_Place != null)
                tags.Add(new SwiftTag("94C", Tag94C_Place));
            if (Tag94F_Place != null)
                tags.Add(new SwiftTag("94F", Tag94F_Place));
            if (Tag35B_IdentificationOfFinancialInstrument != null)
                tags.Add(new SwiftTag("35B", Tag35B_IdentificationOfFinancialInstrument));
            if (SequenceB1 != null)
                tags.AddRange(SequenceB1.GetTags());
            if (Tag93B_Balance != null)
                tags.AddRange(Tag93B_Balance.Select(x => new SwiftTag("93B", x)).ToList());
            if (Tag93C_Balance != null)
                tags.AddRange(Tag93C_Balance.Select(x => new SwiftTag("93C", x)).ToList());
            if (Tag16S_EndOfBlock != null)
                tags.Add(new SwiftTag("16S", Tag16S_EndOfBlock));
            return tags;
        }

        public virtual void SetTags(SwiftTagList tags)
        {
            int i = 0;
            foreach (SwiftTag tag in tags)
            {
                if ((tag == new SwiftTag("16R", Tag16R_StartOfBlock_Value)) && (i <= 1))
                {
                    Tag16R_StartOfBlock = tag.Value;
                    i = 1;
                }
                else if ((tag.Name == "95P") && (i <= 2))
                {
                    Tag95P_Party = tag.Value;
                    i = 2;
                }
                else if ((tag.Name == "95R") && (i <= 2))
                {
                    Tag95R_Party = tag.Value;
                    i = 2;
                }
                else if ((tag.Name == "97A") && (i <= 3))
                {
                    Tag97A_Account = tag.Value;
                    i = 3;
                }
                else if ((tag.Name == "97C") && (i <= 3))
                {
                    Tag97C_Account = tag.Value;
                    i = 3;
                }
                else if ((tag.Name == "94B") && (i <= 4))
                {
                    Tag94B_Place = tag.Value;
                    i = 4;
                }
                else if ((tag.Name == "94C") && (i <= 4))
                {
                    Tag94C_Place = tag.Value;
                    i = 4;
                }
                else if ((tag.Name == "94F") && (i <= 4))
                {
                    Tag94F_Place = tag.Value;
                    i = 4;
                }
                else if ((tag.Name == "35B") && (i <= 5))
                {
                    Tag35B_IdentificationOfFinancialInstrument = tag.Value;
                    i = 5;
                }
                else if ((tag.Name == "93B") && (i <= 6))
                {
                    if (Tag93B_Balance == null)
                        Tag93B_Balance = new List<string>();
                    Tag93B_Balance.Add(tag.Value);
                    i = 6;
                }
                else if ((tag.Name == "93C") && (i <= 6))
                {
                    if (Tag93C_Balance == null)
                        Tag93C_Balance = new List<string>();
                    Tag93C_Balance.Add(tag.Value);
                    i = 6;
                }
                else if ((tag == new SwiftTag("16S", Tag16S_EndOfBlock_Value)) && (i <= 7))
                {
                    Tag16S_EndOfBlock = tag.Value;
                    i = 7;
                }
            }
            SequenceB1 = MT568_SequenceB1.GetMT568_SequenceB1(tags);
        }

        public static MT568_SequenceB GetMT568_SequenceB(SwiftTagList tags)
        {
            SwiftTagList subBlock = tags.GetSubBlock(new SwiftTag("16R", MT568_SequenceB.Tag16R_StartOfBlock_Value), new SwiftTag("16S", MT568_SequenceB.Tag16S_EndOfBlock_Value));
            return new MT568_SequenceB(subBlock);
        }
    }

    /// <summary>
    /// Financial Instrument Attributes
    /// <summary>
    public partial class MT568_SequenceB1
    {

        public static readonly string Tag16R_StartOfBlock_Value = "FIA";
        /// <summary>
        /// Start Of Block
        /// <summary>
		public string Tag16R_StartOfBlock { get; set; }
        /// <summary>
        /// Place of Safekeeping
        /// <summary>
		public string Tag94B_Place { get; set; }
        /// <summary>
        /// Corporate Action Event Indicator
        /// <summary>
		public string Tag22F_Indicator { get; set; }
        /// <summary>
        /// Classification Type
        /// <summary>
		public string Tag12A_TypeOfFinancialInstrument { get; set; }
        /// <summary>
        /// Classification Type
        /// <summary>
		public string Tag12C_TypeOfFinancialInstrument { get; set; }
        /// <summary>
        /// Currency of Denomination
        /// <summary>
		public string Tag11A_Currency { get; set; }
        /// <summary>
        /// Date
        /// <summary>
		public List<string> Tag98A_Date { get; set; }
        /// <summary>
        ///  Rate
        /// <summary>
		public List<string> Tag92A_Rate { get; set; }
        /// <summary>
        /// Quantity of Financial Instrument
        /// <summary>
		public List<string> Tag36B_QuantityOfFinancialInstrument { get; set; }
        public static readonly string Tag16S_EndOfBlock_Value = "FIA";
        /// <summary>
        /// End Of Block
        /// <summary>
		public string Tag16S_EndOfBlock { get; set; }

        public MT568_SequenceB1()
        {
        }

        public MT568_SequenceB1(SwiftTagList tags)
        {
            SetTags(tags);
        }

        public virtual SwiftTagList GetTags()
        {
            SwiftTagList tags = new SwiftTagList();
            if (Tag16R_StartOfBlock != null)
                tags.Add(new SwiftTag("16R", Tag16R_StartOfBlock));
            if (Tag94B_Place != null)
                tags.Add(new SwiftTag("94B", Tag94B_Place));
            if (Tag22F_Indicator != null)
                tags.Add(new SwiftTag("22F", Tag22F_Indicator));
            if (Tag12A_TypeOfFinancialInstrument != null)
                tags.Add(new SwiftTag("12A", Tag12A_TypeOfFinancialInstrument));
            if (Tag12C_TypeOfFinancialInstrument != null)
                tags.Add(new SwiftTag("12C", Tag12C_TypeOfFinancialInstrument));
            if (Tag11A_Currency != null)
                tags.Add(new SwiftTag("11A", Tag11A_Currency));
            if (Tag98A_Date != null)
                tags.AddRange(Tag98A_Date.Select(x => new SwiftTag("98A", x)).ToList());
            if (Tag92A_Rate != null)
                tags.AddRange(Tag92A_Rate.Select(x => new SwiftTag("92A", x)).ToList());
            if (Tag36B_QuantityOfFinancialInstrument != null)
                tags.AddRange(Tag36B_QuantityOfFinancialInstrument.Select(x => new SwiftTag("36B", x)).ToList());
            if (Tag16S_EndOfBlock != null)
                tags.Add(new SwiftTag("16S", Tag16S_EndOfBlock));
            return tags;
        }

        public virtual void SetTags(SwiftTagList tags)
        {
            int i = 0;
            foreach (SwiftTag tag in tags)
            {
                if ((tag == new SwiftTag("16R", Tag16R_StartOfBlock_Value)) && (i <= 1))
                {
                    Tag16R_StartOfBlock = tag.Value;
                    i = 1;
                }
                else if ((tag.Name == "94B") && (i <= 2))
                {
                    Tag94B_Place = tag.Value;
                    i = 2;
                }
                else if ((tag.Name == "22F") && (i <= 3))
                {
                    Tag22F_Indicator = tag.Value;
                    i = 3;
                }
                else if ((tag.Name == "12A") && (i <= 4))
                {
                    Tag12A_TypeOfFinancialInstrument = tag.Value;
                    i = 4;
                }
                else if ((tag.Name == "12C") && (i <= 4))
                {
                    Tag12C_TypeOfFinancialInstrument = tag.Value;
                    i = 4;
                }
                else if ((tag.Name == "11A") && (i <= 5))
                {
                    Tag11A_Currency = tag.Value;
                    i = 5;
                }
                else if ((tag.Name == "98A") && (i <= 6))
                {
                    if (Tag98A_Date == null)
                        Tag98A_Date = new List<string>();
                    Tag98A_Date.Add(tag.Value);
                    i = 6;
                }
                else if ((tag.Name == "92A") && (i <= 7))
                {
                    if (Tag92A_Rate == null)
                        Tag92A_Rate = new List<string>();
                    Tag92A_Rate.Add(tag.Value);
                    i = 7;
                }
                else if ((tag.Name == "36B") && (i <= 8))
                {
                    if (Tag36B_QuantityOfFinancialInstrument == null)
                        Tag36B_QuantityOfFinancialInstrument = new List<string>();
                    Tag36B_QuantityOfFinancialInstrument.Add(tag.Value);
                    i = 8;
                }
                else if ((tag == new SwiftTag("16S", Tag16S_EndOfBlock_Value)) && (i <= 9))
                {
                    Tag16S_EndOfBlock = tag.Value;
                    i = 9;
                }
            }
        }

        public static MT568_SequenceB1 GetMT568_SequenceB1(SwiftTagList tags)
        {
            SwiftTagList subBlock = tags.GetSubBlock(new SwiftTag("16R", MT568_SequenceB1.Tag16R_StartOfBlock_Value), new SwiftTag("16S", MT568_SequenceB1.Tag16S_EndOfBlock_Value));
            return new MT568_SequenceB1(subBlock);
        }
    }

    /// <summary>
    /// Additional Information
    /// <summary>
    public partial class MT568_SequenceC
    {

        public static readonly string Tag16R_StartOfBlock_Value = "ADDINFO";
        /// <summary>
        /// Start Of Block
        /// <summary>
		public string Tag16R_StartOfBlock { get; set; }
        /// <summary>
        /// Narrative
        /// <summary>
		public List<string> Tag70E_Narrative { get; set; }
        /// <summary>
        /// Narrative
        /// <summary>
		public List<string> Tag70F_Narrative { get; set; }
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
        /// End Of Block
        /// <summary>
		public string Tag16S_EndOfBlock { get; set; }

        public MT568_SequenceC()
        {
        }

        public MT568_SequenceC(SwiftTagList tags)
        {
            SetTags(tags);
        }

        public virtual SwiftTagList GetTags()
        {
            SwiftTagList tags = new SwiftTagList();
            if (Tag16R_StartOfBlock != null)
                tags.Add(new SwiftTag("16R", Tag16R_StartOfBlock));
            if (Tag70E_Narrative != null)
                tags.AddRange(Tag70E_Narrative.Select(x => new SwiftTag("70E", x)).ToList());
            if (Tag70F_Narrative != null)
                tags.AddRange(Tag70F_Narrative.Select(x => new SwiftTag("70F", x)).ToList());
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
            foreach (SwiftTag tag in tags)
            {
                if ((tag == new SwiftTag("16R", Tag16R_StartOfBlock_Value)) && (i <= 1))
                {
                    Tag16R_StartOfBlock = tag.Value;
                    i = 1;
                }
                else if ((tag.Name == "70E") && (i <= 2))
                {
                    if (Tag70E_Narrative == null)
                        Tag70E_Narrative = new List<string>();
                    Tag70E_Narrative.Add(tag.Value);
                    i = 2;
                }
                else if ((tag.Name == "70F") && (i <= 2))
                {
                    if (Tag70F_Narrative == null)
                        Tag70F_Narrative = new List<string>();
                    Tag70F_Narrative.Add(tag.Value);
                    i = 2;
                }
                else if ((tag.Name == "95P") && (i <= 3))
                {
                    if (Tag95P_Party == null)
                        Tag95P_Party = new List<string>();
                    Tag95P_Party.Add(tag.Value);
                    i = 3;
                }
                else if ((tag.Name == "95R") && (i <= 3))
                {
                    if (Tag95R_Party == null)
                        Tag95R_Party = new List<string>();
                    Tag95R_Party.Add(tag.Value);
                    i = 3;
                }
                else if ((tag.Name == "95Q") && (i <= 3))
                {
                    if (Tag95Q_Party == null)
                        Tag95Q_Party = new List<string>();
                    Tag95Q_Party.Add(tag.Value);
                    i = 3;
                }
                else if ((tag == new SwiftTag("16S", Tag16S_EndOfBlock_Value)) && (i <= 4))
                {
                    Tag16S_EndOfBlock = tag.Value;
                    i = 4;
                }
            }
        }

        public static MT568_SequenceC GetMT568_SequenceC(SwiftTagList tags)
        {
            SwiftTagList subBlock = tags.GetSubBlock(new SwiftTag("16R", MT568_SequenceC.Tag16R_StartOfBlock_Value), new SwiftTag("16S", MT568_SequenceC.Tag16S_EndOfBlock_Value));
            return new MT568_SequenceC(subBlock);
        }
    }
}
