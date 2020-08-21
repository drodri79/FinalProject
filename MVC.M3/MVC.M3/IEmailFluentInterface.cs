using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Mail;

namespace MVC.M3
{
    public interface IEmailFluentInterface
    {
        IEmailFluentInterface From(string fromAddress);
        IEmailFluentInterface To(params string[] toAddresses);
        IEmailFluentInterface CC(params string[] ccAddresses);
        IEmailFluentInterface BCC(params string[] bccAddresses);
        IEmailFluentInterface WithSubject(string subject);
        IEmailFluentInterface WithBody(string body);
        void Send();
    }
}

