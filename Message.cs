using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProblem
{
    internal class Message
    {
        public DateTime Date { get; set; }
        public Person Sender { get; set; }
        public Person Receiver { get; set; }
        public string Content { get; set; }
        public bool IsRead { get; set; }

        public override string ToString()
        {
            return $"{Date}##{Sender}##{Receiver}##{Content}##{IsRead}";
        }
    }

}