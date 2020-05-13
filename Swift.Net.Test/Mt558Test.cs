using Microsoft.VisualStudio.TestTools.UnitTesting;
using Swift.Net.Mt.Category5;
using System.IO;

namespace Swift.Net.Test
{
    [TestClass]
    public class Mt558Test
    {
        [TestMethod]
        public void GetMt558_SwiftFileOutput_ReturnSwiftMessage()
        {
            string messageText = "";
            using (StreamReader stream = new StreamReader(@"..\..\..\SwiftFiles\Mt558"))
            {
                messageText = stream.ReadToEnd();
            }

            SwiftParser parser = new SwiftParser();
            MT558 result = Mt.Category5.MT558.Parse(messageText);

            Assert.AreEqual(messageText, result.ToString());
        }
    }
}
