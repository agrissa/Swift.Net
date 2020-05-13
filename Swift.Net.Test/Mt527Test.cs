using Microsoft.VisualStudio.TestTools.UnitTesting;
using Swift.Net.Mt.Category5;
using System.IO;

namespace Swift.Net.Test
{
    [TestClass]
    public class Mt527Test
    {
        [TestMethod]
        public void GetMt527_SwiftFileOutput_ReturnSwiftMessage()
        {
            string messageText = "";
            using (StreamReader stream = new StreamReader(@"..\..\..\SwiftFiles\Mt527"))
            {
                messageText = stream.ReadToEnd();
            }

            SwiftParser parser = new SwiftParser();
            MT527 result = Mt.Category5.MT527.Parse(messageText);

            Assert.AreEqual(messageText, result.ToString());
        }
    }
}
