using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternDimitri.Creazionali.Builder
{
    public class Email
    {
        public string From, To, Subject, Body;
    }
   

    public class MailService
    {
        public class EmailBuilder
        {
            private readonly Email email;
            public EmailBuilder(Email email)
            {
                this.email = email;
            }
            public EmailBuilder From(string from)
            {
                email.From = from;
                return this;
            }
        }

        private void SendEmailInternal(Email email)
        { 
        
        }

        public void SendEmail(Action<EmailBuilder> buildEmail)
        {
            var email = new Email();
            buildEmail(new EmailBuilder(email)); //invoke delegate
            SendEmailInternal(email);
        }
    }
}
