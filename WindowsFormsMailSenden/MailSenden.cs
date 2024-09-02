using System;
using System.Windows.Forms;
using MailKit.Net.Smtp;
using MailKit.Security;
using MimeKit;

namespace WindowsFormsMailSenden
{
    internal class MailSenden
    {
        private const string HOST_NAME = "smtp.office365.com";
        private const int HOST_PORT = 587;
        private const string MAIL_SENT = "Mail sent.";
        private const string EMPTY = "";
        private const string MAIL_ADDRESS_FOR_AUTHENTICATION = "mail address for authentication";
        private const string SENDER_NAME = "sender name";

        public void SendMail(String adresse, String titel, String text, String password)
        {
            String resultat = Senden(adresse, titel, text, password);

            if (!resultat.Equals(""))
            {
                MessageBox.Show(resultat, "Information");
            }
        }

        private String Senden(String adresse, String titel, String text, String passwort)
        {
            MimeMessage message = new MimeMessage();

            message.From.Add(new MailboxAddress(SENDER_NAME, MAIL_ADDRESS_FOR_AUTHENTICATION));
            message.To.Add(MailboxAddress.Parse(adresse));
            message.Subject = titel;
            message.Body = new TextPart("Plain")
            {
                Text = text
            };

            SmtpClient client = new SmtpClient();
            String resultText = EMPTY;

            try
            {
                // "open" SMTP server, which authenticates automatically
                client.Connect(HOST_NAME, HOST_PORT, SecureSocketOptions.StartTls);
                client.Authenticate(MAIL_ADDRESS_FOR_AUTHENTICATION, passwort);
                client.Send(message);
                resultText = MAIL_SENT;
            }
            catch (Exception ex)
            {
                resultText = ex.Message;
            }
            finally
            {
                client.Disconnect(true);
                client.Dispose();
            }
            return resultText;
        }
    }
}
