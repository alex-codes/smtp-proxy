# smtp-proxy

A small, mockable proxy for the SmtpClient class.

```
// configure with your ioc container to use SmtpProxy.
// SmtpProxy is an instance of SmtpClient.
// use the abstraction exactly how you use SmtpClient.

public class MyClass
{
    private ISmtpClient smtpClient;

    public MyClass(ISmtpClient smtpClient)
    {
        this.smtpClient = smtpClient;
    }

    public void SendMail(MailMessage message)
    {
        // you can set host, port, ssl certificates, etc
        smtpClient.Send(message);
    }
}
```

## SmtpClientProxy

The `SmtpClientProxy` class inherits from `SmtpClient` and implements the `ISmtpClient` interface. This allows your SMTP client object to be mockable and injectable. You can also use an instance of the `ISmtpClientFactory` to generate an instance of `SmtpClientProxy`. A `DefaultSmtpClientFactory` is included.

## Construction

```
// the default constructor uses <mailsettings> section in your config file
SmtpClientProxy();
SmtpClientProxy(string host);
SmtpClientProxy(string host, int port);
```

Using the factory:

```
ISmtpClientFactory factory = new DefaultSmtpClientFactory();
ISmtpClient smtpClient = factory.CreateSmtpClient();
smtpClient.Send(message);
```

### ISmtpClient Interface

```
X509CertificateCollection ClientCertificates { get; }
ICredentialsByHost Credentials { get; set; }
SmtpDeliveryFormat DeliveryFormat { get; set; }
SmtpDeliveryMethod DeliveryMethod { get; set; }
bool EnableSsl { get; set; }
string Host { get; set; }
string PickupDirectoryLocation { get; set; }
int Port { get; set; }
ServicePoint ServicePoint { get; }
string TargetName { get; set; }
int Timeout { get; set; }
bool UseDefaultCredentials { get; set; }

void Send(string from, string recipients, string subject, string body);
void Send(MailMessage message);
void SendAsync(string from, string recipients, string subject, string body, object userToken);
void SendAsync(MailMessage message, object userToken);
Task SendMailAsync(MailMessage message);
Task SendMailAsync(string from, string recipients, string subject, string body);
void SendAsyncCancel();
event SendCompletedEventHandler SendCompleted;
```

### ISmtpClientFactory

```
ISmtpClient CreateSmtpClient();
ISmtpClient CreateSmtpClient(string host);
ISmtpClient CreateSmtpClient(string host, int port);
```