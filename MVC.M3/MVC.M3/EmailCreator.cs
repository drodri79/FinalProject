﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Net;
using System.Net.Mail;

namespace MVC.M3
{
    public class EmailCreator : IEmailFluentInterface
    {
        private MailMessage _mailMessage = new MailMessage();

        private EmailCreator(string fromAddress)
        {
            _mailMessage.Sender = new MailAddress(fromAddress);
        }

        public static IEmailFluentInterface CreateEmailFrom(string fromAddress)
        {
            return new EmailCreator(fromAddress);
        }

        public IEmailFluentInterface From(string fromAddress)
        {
            return this;
        }

        public IEmailFluentInterface To(params string[] toAddresses)
        {
            foreach (string toAddress in toAddresses)
            {
                _mailMessage.To.Add(new MailAddress(toAddress));
            }

            return this;
        }

        public IEmailFluentInterface CC(params string[] ccAddresses)
        {
            foreach (string ccAddress in ccAddresses)
            {
                _mailMessage.CC.Add(new MailAddress(ccAddress));
            }

            return this;
        }

        public IEmailFluentInterface BCC(params string[] bccAddresses)
        {
            foreach (string bccAddress in bccAddresses)
            {
                _mailMessage.Bcc.Add(new MailAddress(bccAddress));
            }

            return this;
        }

        public IEmailFluentInterface WithSubject(string subject)
        {
            _mailMessage.Subject = subject;

            return this;
        }

        public IEmailFluentInterface WithBody(string body)
        {
            _mailMessage.Body = body;

            return this;
        }

        public void Send()
        {
            // Set up the mail server
            SmtpClient smtpClient = new SmtpClient("mailservername");
            smtpClient.Credentials = CredentialCache.DefaultNetworkCredentials;
            smtpClient.Timeout = 100;

            // Send the email
            smtpClient.Send(_mailMessage);
        }
    }

}