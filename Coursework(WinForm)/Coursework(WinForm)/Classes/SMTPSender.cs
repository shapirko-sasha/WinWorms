﻿using EASendMail;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coursework_WinForm_.Classes
{
    class SMTPSender : IDisposable
    {
        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
        public bool SendMessage(string email, string subject, string html)
        {
            email = "sashaworksha@gmail.com";
            subject = "hell0";
            html = "<b> text</b>";

            try
            {
                SmtpServer server = new SmtpServer("smtp.gmail.com")
                {
                    Port = 587,
                    ConnectType = SmtpConnectType.ConnectSSLAuto,
                    User = "itstudentyre@gmail.com",
                    Password = "Qw3eI98*63%"
                };
                SmtpMail message = new SmtpMail("TryIt")
                {
                    From = server.User,
                    To = email,
                    Subject = subject,
                    //TextBody = html,
                    Priority = MailPriority.High,
                    HtmlBody = html
                };
                SmtpClient client = new SmtpClient();
                client.SendMail(server, message);
            }
            catch (Exception ex)
            {
                return false;
            }
            return true;
        }
    }
}
