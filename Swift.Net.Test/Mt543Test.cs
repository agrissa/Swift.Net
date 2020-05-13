using Microsoft.VisualStudio.TestTools.UnitTesting;
using Swift.Net.Mt.Category5;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Swift.Net.Test
{
    [TestClass]
    public class Mt543Test
    {
        [TestMethod]
        public void GetMt543_SwiftFileOutput_ReturnSwiftMessage()
        {
            string messageText = "";
            using (StreamReader stream = new StreamReader(@"..\..\..\SwiftFiles\Mt543"))
            {
                messageText = stream.ReadToEnd();
            }

            SwiftParser parser = new SwiftParser();
            MT543 result = Mt.Category5.MT543.Parse(messageText);

            Assert.AreEqual(messageText, result.ToString());
        }
    }
}
