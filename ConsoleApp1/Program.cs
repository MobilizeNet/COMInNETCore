using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var myMail = new CDO.Message();
            myMail.Subject = "Sending email with CDO";
            myMail.From = "mauricio.rojas@mobilize.net";
            myMail.To = "orellabac@gmail.com";
            myMail.HTMLBody = "<h1>This is a message.</h1>";

            myMail.Configuration.Fields["http://schemas.microsoft.com/cdo/configuration/sendusing"].Value = 2;
            myMail.Configuration.Fields["http://schemas.microsoft.com/cdo/configuration/smtpserver"].Value = "localhost";
            myMail.Configuration.Fields["http://schemas.microsoft.com/cdo/configuration/smtpserverport"].Value = 25;
            myMail.Configuration.Fields.Update();
            myMail.Send();
            myMail = null;
        }
    }
}
