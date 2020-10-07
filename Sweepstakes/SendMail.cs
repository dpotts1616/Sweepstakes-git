using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Mail;

namespace Sweepstakes
{
    public class SendMail
    {
        static string smtpAddress = "smtp.gmail.com";
        static int portNumber = 587;
        static bool enableSSL = true;
        static string emailFromAddress = "dp5718259@gmail.com"; //Sender Email Address  
        static string password = "devcodecamp2020"; //Sender Password  
        //static string emailToAddress; //Receiver Email Address  
        //static string subject = "Hello";
        //static string body = "Hello, This is Email sending test using gmail.";



        public static void SendEmail(string emailToAddress, string subject, string body)
        {
            using (SmtpClient client = new SmtpClient(smtpAddress, portNumber))
            {
                client.Credentials = new NetworkCredential(emailFromAddress, password);
                client.EnableSsl = enableSSL;
                MailMessage eMail = new MailMessage(emailFromAddress, emailToAddress, subject, body);
                client.Send(eMail);
            }
        }
    }
}
