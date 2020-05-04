using Microsoft.VisualStudio.TestTools.UnitTesting;
using Swift.Net;
using System.Collections.Generic;
using System.IO;

namespace Swift.Net.Test
{
    [TestClass]
    public class SwiftParserTest
    {
        [TestMethod]
        public void GetSwiftMessage_SwiftFileOutput_ReturnSwiftMessage()
        {
            string messageText = "";
            using (StreamReader stream = new StreamReader(@"..\..\..\SwiftFiles\GetSwiftMessage_SwiftFileOutput_ReturnSwiftMessage"))
            {
                messageText = stream.ReadToEnd();
            }
            SwiftMessage swiftMessage = new SwiftMessage()
            {
                Block1 = new SwiftBlock1()
                {
                    ApplicationId = "F",
                    ServiceId = "01",
                    LogicalTerminalAddress = "TESTBIC12XXX",
                    SessionNumber = "0360",
                    SequenceNumber = "105154",
                },
                Block2 = new SwiftBlock2Output()
                {
                    Direction = Direction.Output,
                    MessageType = "564",
                    InputTime = "1057",
                    MessageInputReference = new MessageInputReference()
                    {
                        InputDate = "130214",
                        LogicalTerminalAddress = "TESTBIC34XXX",
                        SessionNumber = "2626",
                        SequenceNumber = "493828"
                    },
                    ReceiverOutputDate = "130214",
                    ReceiverOutputTime = "1757",
                    MessagePriority = "N"
                },
                Block3 = new SwiftBlock3()
                {
                    new SwiftTag("103", "CAD"),
                    new SwiftTag("108", "2RDRQDHM3WO"),
                },
                Block4 = new SwiftBlock4()
                {
                    new SwiftTag("16R", "GENL"),
                    new SwiftTag("20C", ":CORP//1234567890123456"),
                    new SwiftTag("20C", ":SEME//9876543210987654"),
                    new SwiftTag("23G", "NEWM"),
                    new SwiftTag("22F", ":CAEV//INTR"),
                    new SwiftTag("22F", ":CAMV//MAND"),
                    new SwiftTag("98C", ":PREP//20220202105733"),
                    new SwiftTag("25D", ":PROC//ENTL"),
                    new SwiftTag("16S", "GENL"),
                    new SwiftTag("16R", "USECU"),
                    new SwiftTag("35B", "ISIN CH0101010101\r\n/XS/232323232\r\nFINANCIAL INSTRUMENT ACME"),
                    new SwiftTag("16R", "FIA"),
                    new SwiftTag("22F", ":MICO//A007"),
                    new SwiftTag("16S", "FIA"),
                    new SwiftTag("16R", "ACCTINFO"),
                    new SwiftTag("97A", ":SAFE//99999"),
                    new SwiftTag("94F", ":SAFE//NCSD/TESTBIC0ABC"),
                    new SwiftTag("93B", ":ELIG//FAMT/500000,"),
                    new SwiftTag("93B", ":SETT//FAMT/500000,"),
                    new SwiftTag("16S", "ACCTINFO"),
                    new SwiftTag("16S", "USECU"),
                    new SwiftTag("16R", "CADETL"),
                    new SwiftTag("98A", ":ANOU//20220113"),
                    new SwiftTag("98A", ":RDTE//20220113"),
                    new SwiftTag("69A", ":INPE//20220214/20220214"),
                    new SwiftTag("99A", ":DAAC//360"),
                    new SwiftTag("92K", ":INTR//UKWN"),
                    new SwiftTag("22F", ":ADDB//CAPA"),
                    new SwiftTag("16S", "CADETL"),
                    new SwiftTag("16R", "CAOPTN"),
                    new SwiftTag("13A", ":CAON//001"),
                    new SwiftTag("22F", ":CAOP//CASH"),
                    new SwiftTag("11A", ":OPTN//USD"),
                    new SwiftTag("17B", ":DFLT//Y"),
                    new SwiftTag("16R", "CASHMOVE"),
                    new SwiftTag("22H", ":CRDB//CRED"),
                    new SwiftTag("22H", ":CONT//ACTU"),
                    new SwiftTag("97A", ":CASH//89898"),
                    new SwiftTag("19B", ":ENTL//USD3333,"),
                    new SwiftTag("19B", ":TXFR//USD3333,"),
                    new SwiftTag("19B", ":NETT//USD3333,"),
                    new SwiftTag("98A", ":PAYD//20220214"),
                    new SwiftTag("98A", ":VALU//20220214"),
                    new SwiftTag("98A", ":EARL//20220214"),
                    new SwiftTag("92A", ":INTP//0,75"),
                    new SwiftTag("92A", ":TAXR//0,"),
                    new SwiftTag("16S", "CASHMOVE"),
                    new SwiftTag("16S", "CAOPTN"),
                    new SwiftTag("16R", "ADDINFO"),
                    new SwiftTag("70E", ":ADTX//PAYMENT UPON RECEIPT OF FUNDS - \r\nTIMELY PAYMENT EXPECTED"),
                    new SwiftTag("16S", "ADDINFO"),
                },
                Block5 = new SwiftBlock5()
                {
                    new SwiftTag("CHK", "C77F8E009597")
                }
            };
            SwiftParser parser = new SwiftParser();
            var result = parser.GetSwiftMessage(messageText);
            Assert.AreEqual(result, swiftMessage);
        }
    }
}
