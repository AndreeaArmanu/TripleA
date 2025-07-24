using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProblem
{
    internal class EmptyMessageException : Exception
    {
        public Message ProblematicMessage { get; }

        public EmptyMessageException(string message, Message problematicMessage) : base(message)
        {
            ProblematicMessage = problematicMessage;
        }

        public void Print()
        {
            Console.WriteLine(" EmptyMessageException: Message content is empty.");
            Console.WriteLine($"Date: {ProblematicMessage.Date}");
            Console.WriteLine($"Sender: {ProblematicMessage.Sender}");
            Console.WriteLine($"Receiver: {ProblematicMessage.Receiver}");
        }
    }
}