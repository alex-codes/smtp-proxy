using System;
using System.Net;
using System.Net.Mail;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace SmtpProxy
{
    // i just took all of the public properties and methods from the SmtpClient class and made this interface out of it
    // this is meant to be used for testing

    /// <summary>
    /// An implementation of ISmtpClient used to send email.
    /// </summary>
    public interface ISmtpClient : IDisposable
    {
        /// <summary>
        /// Specify which certificates should be used to establish the Secure Sockets Layer.
        /// </summary>
        X509CertificateCollection ClientCertificates { get; }

        /// <summary>
        /// Gets or sets the credentials used to authenticate the sender.
        /// </summary>
        ICredentialsByHost Credentials { get; set; }

        /// <summary>
        /// Gets or sets the delivery format used by System.Net.Mail.SmtpClient to send e-mail.
        /// </summary>
        SmtpDeliveryFormat DeliveryFormat { get; set; }

        /// <summary>
        ///  how outgoing email messages will be handled.
        /// </summary>
        SmtpDeliveryMethod DeliveryMethod { get; set; }

        /// <summary>
        /// Specify whether the System.Net.Mail.SmtpClient uses Secure Sockets Layer (SSL) to encrypt the connection.
        /// </summary>
        bool EnableSsl { get; set; }

        /// <summary>
        /// Gets or sets the name or IP address of the host used for SMTP transactions.
        /// </summary>
        string Host { get; set; }

        /// <summary>
        /// Gets or sets the folder where applications save mail messages to be processed by the local SMTP server.
        /// </summary>
        string PickupDirectoryLocation { get; set; }

        /// <summary>
        /// Gets or sets the port used for SMTP transactions.
        /// </summary>
        int Port { get; set; }

        /// <summary>
        /// Gets the network connection used to transmit the e-mail message.
        /// </summary>
        ServicePoint ServicePoint { get; }


        string TargetName { get; set; }

        /// <summary>
        /// Gets or sets a value that specifies the amount of time after which a synchronous Send call times out.
        /// </summary>
        int Timeout { get; set; }

        /// <summary>
        /// Gets or sets a System.Boolean value that controls whether the System.Net.CredentialCache.DefaultCredentials are sent with requests.
        /// </summary>
        bool UseDefaultCredentials { get; set; }

        /// <summary>
        /// Sends the specified e-mail message to an SMTP server for delivery. The message
        /// sender, recipients, subject, and message body are specified using System.String
        /// objects.
        /// </summary>
        /// <param name="from">A System.String that contains the address information of the message sender.</param>
        /// <param name="recipients"></param>
        /// <param name="subject">A System.String that contains the subject line for the message.</param>
        /// <param name="body">A System.String that contains the message body.</param>
        void Send(string from, string recipients, string subject, string body);

        /// <summary>
        /// Sends the specified message to an SMTP server for delivery.
        /// </summary>
        /// <param name="message">A System.Net.Mail.MailMessage that contains the message to send.</param>
        void Send(MailMessage message);

        /// <summary>
        /// Sends an e-mail message to an SMTP server for delivery. The message sender, recipients,
        /// subject, and message body are specified using System.String objects. This method
        /// does not block the calling thread and allows the caller to pass an object to
        /// the method that is invoked when the operation completes.
        /// </summary>
        /// <param name="from">A System.String that contains the address information of the message sender.</param>
        /// <param name="recipients"></param>
        /// <param name="subject">A System.String that contains the subject line for the message.</param>
        /// <param name="body">A System.String that contains the message body.</param>
        /// <param name="userToken">A user-defined object that is passed to the method invoked when the asynchronous operation completes.</param>
        void SendAsync(string from, string recipients, string subject, string body, object userToken);

        /// <summary>
        /// Sends the specified e-mail message to an SMTP server for delivery. This method
        /// does not block the calling thread and allows the caller to pass an object to
        /// the method that is invoked when the operation completes.
        /// </summary>
        /// <param name="message">A System.Net.Mail.MailMessage that contains the message to send.</param>
        /// <param name="userToken">A user-defined object that is passed to the method invoked when the asynchronous operation completes.</param>
        void SendAsync(MailMessage message, object userToken);

        /// <summary>
        /// Sends the specified message to an SMTP server for delivery as an asynchronous operation.
        /// </summary>
        /// <param name="message"></param>
        /// <returns></returns>
        Task SendMailAsync(MailMessage message);

        /// <summary>
        /// Sends the specified message to an SMTP server for delivery as an asynchronous
        /// operation. . The message sender, recipients, subject, and message body are specified
        /// using System.String objects.
        /// </summary>
        /// <param name="from">A System.String that contains the address information of the message sender.</param>
        /// <param name="recipients"></param>
        /// <param name="subject">A System.String that contains the subject line for the message.</param>
        /// <param name="body">A System.String that contains the message body.</param>
        /// <returns></returns>
        Task SendMailAsync(string from, string recipients, string subject, string body);

        /// <summary>
        /// Cancels an asynchronous operation to send an e-mail message.
        /// </summary>
        void SendAsyncCancel();

        /// <summary>
        /// Occurs when an asynchronous e-mail send operation completes.
        /// </summary>
        event SendCompletedEventHandler SendCompleted;
    }
}
