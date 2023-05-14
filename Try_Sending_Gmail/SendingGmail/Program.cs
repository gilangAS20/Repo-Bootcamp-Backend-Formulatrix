// See https://aka.ms/new-console-template for more information
using System;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;

namespace TrySendingGmail
{
    class Program
    {
        static void Main()
        {
            System.Console.WriteLine("===SENDING A GMAIL MESSAGE===\n\n");
            string myEmailAccount = "@gmail.com"; // tanya gilang
            string myEmailPassword = ""; // tanya gilang

            //make instance message
            MailMessage message = new MailMessage();
            message.From = new MailAddress(myEmailAccount);

            //add recipient
            message.To.Add( new MailAddress("@gmail.com") ); // isi email penerima

            // add subject and body
            message.Subject = "Gilang Try Sending Gmail with C# Console";
            message.Body = "Hello, this is my first time sending gmail with C# Console";

            var SmtpClient = new SmtpClient("smtp.gmail.com")
            {
                Port = 587,
                Credentials = new NetworkCredential(myEmailAccount, myEmailPassword),
                EnableSsl = true,
            };

            //send message
            SmtpClient.Send(message);
        }
    }
}
