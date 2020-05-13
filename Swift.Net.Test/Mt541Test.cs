using Microsoft.VisualStudio.TestTools.UnitTesting;
using Swift.Net.Mt.Category5;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Swift.Net.Test
{
    [TestClass]
    public class Mt541Test
    {
        [TestMethod]
        public void GetMt541_SwiftFileOutput_ReturnSwiftMessage()
        {
            string messageText = "";
            using (StreamReader stream = new StreamReader(@"..\..\..\SwiftFiles\Mt541"))
            {
                messageText = stream.ReadToEnd();
            }

            SwiftParser parser = new SwiftParser();
            MT541 result = Mt.Category5.MT541.Parse(messageText);

            Assert.AreEqual(messageText, result.ToString());
        }
    }
}
