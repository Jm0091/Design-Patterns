using System;
using System.Collections.Generic;
using System.Text;

namespace Problem3
{
    /// <summary>
    /// This Class provide the concrete implmentation for the Mailbox.
    /// It handles all the letter mail.
    /// </summary>
    public class LetterMailBox : MailBox
    {
        public override MailType Type => MailType.Letter;

        public override void Handle(Mail mail)
        {
            Console.WriteLine("Sending to appropriate receiver ..");
        }
    }
}
