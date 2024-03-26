using System;
using System.Collections.Generic;
using System.Text;

namespace Problem3
{
    /// <summary>
    /// This Class provide the concrete implmentation for the Mailbox.
    /// It handles Package mail.
    /// </summary>
    public class PackageMailBox : MailBox
    {
        public override MailType Type => MailType.Package;
        public override void Handle(Mail mail)
        {
            Console.WriteLine("Sending to appropriate receiver ..");
        }
    }
}
