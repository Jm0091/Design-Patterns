using System;
using System.Collections.Generic;
using System.Text;

namespace Problem3
{
    /// <summary>
    /// This class represent the Mail.
    /// </summary>
    public class Mail
    {
        public string SenderName { get; set; }
        public string SenderAddress { get; set; }
        public string ReceiverName { get; set; }
        public string ReceiverAddress { get; set; }
        public decimal PostalCost { get; set; }
        public double Weight { get; set; }
        public MailType Type { get; set; }
    }

    public enum MailType { 
        Letter,
        Package
    }
}
