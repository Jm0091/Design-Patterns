using System;
using System.Collections.Generic;
using System.Text;

namespace Problem3
{
    /// <summary>
    /// This is abstract class to provide interface for different request handler. 
    /// </summary>
    public abstract class MailBox
    {
        protected MailBox() { 
        }

        public abstract MailType Type { get; }
        public abstract void Handle(Mail mail);

    }
}
