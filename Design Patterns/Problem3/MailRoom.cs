using System;
using System.Collections.Generic;
using System.Text;

namespace Problem3
{
    /// <summary>
    /// Problem 3 implements Reactor Pattern.
    /// It handles the initial Request and dipatches it to workers.
    /// </summary>
    public class MailRoom
    {
        private List<MailBox> mailboxes = new List<MailBox>();

        public MailRoom()
        {
            mailboxes.Add(new PackageMailBox());
            mailboxes.Add(new LetterMailBox());
        }

        /// <summary>
        /// Hadler to deal with inital client request
        /// </summary>
        /// <param name="mail">Mail to be deilvered</param>
        public void handle(Mail mail) {
            MailBox mailbox = mailboxes.Find(m => m.Type.Equals(mail.Type));

            if (mailbox == null) {
                throw new InvalidOperationException("Unable to locate mailbox for the mail");
            }

            mailbox.Handle(mail);
        }
    }
}
