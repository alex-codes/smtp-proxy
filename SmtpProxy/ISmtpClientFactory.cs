namespace SmtpProxy
{
    /// <summary>
    /// A factory interface used to generate an instance of ISmtpClient.
    /// </summary>
    public interface ISmtpClientFactory
    {
        /// <summary>
        /// Provides a default implementation of ISmtpClient by using configuration file settings.
        /// </summary>
        /// <see cref="http://msdn.microsoft.com/en-us/library/w355a94k(v=vs.110).aspx"/>
        /// <returns>A new instance of ISmtpClient.</returns>
        ISmtpClient CreateSmtpClient();

        /// <summary>
        /// Provides a default implementation of ISmtpClient.
        /// </summary>
        /// <param name="host">A string that contains the name or IP address of the host computer used for SMTP transactions.</param>
        /// <param name="port">An int greater than zero that contains the port to be used on the host.</param>
        /// <returns>A new instance of ISmtpClient.</returns>
        ISmtpClient CreateSmtpClient(string host);

        /// <summary>
        /// Provides a default implementation of ISmtpClient.
        /// </summary>
        /// <param name="host">A string that contains the name or IP address of the host computer used for SMTP transactions.</param>
        /// <param name="port">An int greater than zero that contains the port to be used on the host.</param>
        /// <returns>A new instance of ISmtpClient.</returns>
        ISmtpClient CreateSmtpClient(string host, int port);
    }
}
