using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShipX.Net.Core;

namespace ShipX.Test
{
    [TestClass]
    public class ShipXClientTest
    {
        private ShipXClient _client;
        private Ini _iniParser;

        public string OrgId { get; set; }
        public string Token { get; set; }
        
        public ShipXClientTest()
        {
            _iniParser = new Ini(@"c:\shipx.ini");
        }

        [TestMethod]
        public void CreateClient_NoCredentials_ShouldFail()
        {
            try
            {
                _client = new ShipXClient(null, null);
                Assert.Fail();
            }
            catch (Exception ex)
            {
                Assert.IsTrue(ex is Exception);
            }
        }


        [TestMethod]
        public void CreateClient_ShouldOK()
        {
            try
            {
                string orgId = _iniParser.GetValue("ORG");
                string token = _iniParser.GetValue("TOKEN");

                _client = new ShipXClient(orgId, token);

                Assert.IsNotNull(_client);

            }
            catch (Exception ex)
            {
                Assert.IsFalse(ex is Exception);
            }
        }


    }
}
