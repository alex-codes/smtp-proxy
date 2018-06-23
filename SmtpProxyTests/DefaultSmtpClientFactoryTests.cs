using Microsoft.VisualStudio.TestTools.UnitTesting;
using SmtpProxy;

namespace SmtpProxyTests
{
    [TestClass]
    public class DefaultSmtpClientFactoryTests
    {
        [TestMethod]
        public void CreateSmtpclient()
        {
            var factory = new DefaultSmtpClientFactory();
            ISmtpClient client = factory.CreateSmtpClient();

            Assert.IsTrue(client is SmtpClientProxy);
        }
    }
}
