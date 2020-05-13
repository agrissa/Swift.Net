using Microsoft.VisualStudio.TestTools.UnitTesting;
using Swift.Net.Mt.Category5;
using System.IO;

namespace Swift.Net.Test
{
    [TestClass]
    public class Mt548Test
    {
        [TestMethod]
        public void GetMt548_SwiftFileOutput_ReturnSwiftMessage()
        {
            string messageText = "";
            using (StreamReader stream = new StreamReader(@"..\..\..\SwiftFiles\Mt548"))
            {
                messageText = stream.ReadToEnd();
            }

            SwiftParser parser = new SwiftParser();
            MT548 result = Mt.Category5.MT548.Parse(messageText);

            Assert.AreEqual(messageText, result.ToString());
        }
    }
}
