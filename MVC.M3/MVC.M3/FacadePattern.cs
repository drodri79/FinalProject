using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC.M3
{
    public class FacadePattern
    {
        public void SendEmail()
        {
            

            // Send an e-mail - version behind wrapper/facade, with multiple "to", "cc", and "bcc" addresses.
            EmailCreator.CreateEmailFrom("from@test.com")
                .To("to1@test.com", "to2@test.com", "to2@test.com")
                .CC("cc1@test.com", "cc2@test.com")
                .BCC("bcc1@test.com", "bcc2@test.com", "bcc3@test.com", "bcc4@test.com")
                .WithSubject("Email subject here")
                .WithBody("Email body here")
                .Send();
        }
    }
}