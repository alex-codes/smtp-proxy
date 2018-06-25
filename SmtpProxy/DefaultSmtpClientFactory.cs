namespace SmtpProxy
{
    /// <summary>
    /// A default factory to create an ISmtpClient instance.
    /// </summary>
    public sealed class DefaultSmtpClientFactory : ISmtpClientFactory
    {
        /// <summary>
        /// Provides a default implementation of ISmtpClient by using configuration file settings.
        /// </summary>
        /// <see cref="http://msdn.microsoft.com/en-us/library/w355a94k(v=vs.110).aspx"/>
        /// <returns>A new instance of SmtpClientProxy.</returns>
        public ISmtpClient CreateSmtpClient()
        {
            return new SmtpClientProxy();
        }

        /// <summary>
        /// Provides a default implementation of ISmtpClient.
        /// </summary>
        /// <param name="host">A string that contains the name or IP address of the host computer used for SMTP transactions.</param>
        /// <param name="port">An int greater than zero that contains the port to be used on the host.</param>
        /// <returns>A new instance of SmtpClientProxy.</returns>
        public ISmtpClient CreateSmtpClient(string host)
        {
            return new SmtpClientProxy(host);
        }

        /// <summary>
        /// Provides a default implementation of ISmtpClient.
        /// </summary>
        /// <param name="host">A string that contains the name or IP address of the host computer used for SMTP transactions.</param>
        /// <param name="port">An int greater than zero that contains the port to be used on the host.</param>
        /// <returns>A new instance of SmtpClientProxy.</returns>
        public ISmtpClient CreateSmtpClient(string host, int port)
        {
            return new SmtpClientProxy(host, port);
        }
    }
}
