using System;
using System.Net.Mail;

namespace SmtpProxy
{
    /// <summary>
    /// Allows applications to send e-mail by using the Simple Mail Transfer Protocol (SMTP).
    /// </summary>
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1063:ImplementIDisposableCorrectly", Justification = "SmtpClient implements IDisposable.")]
    public class SmtpClientProxy : SmtpClient, ISmtpClient, IDisposable
    {
        /// <summary>
        /// Initializes a new instance of SmtpClientProxy by using configuration file settings.
        /// </summary>
        public SmtpClientProxy()
            : base()
        {

        }

        /// <summary>
        /// Initializes a new instance of SmtpClientProxy by using a specified SMTP server.
        /// </summary>
        /// <param name="host">A string that contains the name or IP address of the host computer used for SMTP transactions.</param>
        public SmtpClientProxy(string host)
            : base(host)
        {

        }

        /// <summary>
        /// Initializes a new instance of SmtpClientProxy by using a specified SMTP server and port.
        /// </summary>
        /// <param name="host">A string that contains the name or IP address of the host computer used for SMTP transactions.</param>
        /// <param name="port">An int greater than zero that contains the port to be used on the host.</param>
        public SmtpClientProxy(string host, int port)
            : base(host, port)
        {

        }
    }
}
