using System;
using System.Collections.Generic;
using System.Formats.Tar;
using System.IO;
using System.Linq;

namespace PracticeProblem
{
    internal class Manager
    {
        private string txtPath = "Messages.txt";
        private List<Message> messages;
        private List<Person> persons;

        public Manager()
        {
            messages = TXTreader.ReadMessagesTXT(txtPath);
            getUniquePersons();
        }

        private void getUniquePersons()
        {
            persons = new List<Person>();

            foreach (var msg in messages)
            {
                if (!persons.Any(p => p.Id == msg.Sender.Id))
                    persons.Add(msg.Sender);

                if (!persons.Any(p => p.Id == msg.Receiver.Id))
                    persons.Add(msg.Receiver);
            }
        }

        public Person getPerson(int id)
        {
            return persons.FirstOrDefault(p => p.Id == id);
        }

        public void PrintUniquePersons()
        {
            Console.WriteLine("List of persons:\n");
            foreach (var p in persons)
                Console.WriteLine(p);
        }

        public void CountMessagesBetween(Person p1, Person p2)
        {
            int count = messages.Count(m =>
                (m.Sender.Id == p1.Id && m.Receiver.Id == p2.Id) ||
                (m.Sender.Id == p2.Id && m.Receiver.Id == p1.Id));

            Console.WriteLine($"\nNumber of messages between {p1.Name} and {p2.Name}: {count}");
        }

        public void PrintMessagesBetween(Person p1, Person p2)
        {
            var conversation = messages
                .Where(m =>
                    (m.Sender.Id == p1.Id && m.Receiver.Id == p2.Id) ||
                    (m.Sender.Id == p2.Id && m.Receiver.Id == p1.Id))
                .OrderBy(m => m.Date);

            Console.WriteLine($"\nMessages between {p1.Name} and {p2.Name}:");

            foreach (var msg in conversation)
                Console.WriteLine(msg);
        }

        public void PrintDate(DateTime date)
        {
            var filtered = messages.Where(m => m.Date.Date == date.Date).OrderBy(m => m.Date);

            Console.WriteLine($"\nMessages from {date.Date.ToShortDateString()}:");
            foreach (var msg in filtered)
                Console.WriteLine(msg);
        }

        public void PrintMessagesFromSender(Person sender)
        {
            var sent = messages.Where(m => m.Sender.Id == sender.Id).OrderBy(m => m.Date);

            Console.WriteLine($"Messages sent by {sender.Name}:");
            foreach (var msg in sent)
                Console.WriteLine(msg);
        }

        public void SaveConversation(Person p1, Person p2, string filePath)
        {
            var conversation = messages
                .Where(m =>
                    (m.Sender.Id == p1.Id && m.Receiver.Id == p2.Id) ||
                    (m.Sender.Id == p2.Id && m.Receiver.Id == p1.Id))
                .OrderBy(m => m.Date)
                .Select(m => m.ToString());

            File.WriteAllLines(filePath, conversation);
            Console.WriteLine($"\nConversation saved to {filePath}");
        }

        public void PrintUnseenMessages()
        {
            var unseen = messages.Where(m => !m.IsRead).OrderBy(m => m.Date);

            Console.WriteLine("Unseen messages:");
            foreach (var msg in unseen)
                Console.WriteLine(msg);
        }

        public void PrintLastMessage(Person receiver, string forbiddenWord)
        {
            var lastMsg = messages
                .Where(m => m.Receiver.Id == receiver.Id)
                .OrderByDescending(m => m.Date)
                .FirstOrDefault();

            if (lastMsg != null)
            {
                int N = forbiddenWord.Length;
                string censored = lastMsg.Content.Replace(forbiddenWord, new string('*', N));
                Console.WriteLine($"\nLast message received by {receiver.Name}:");
                Console.WriteLine($"{lastMsg.Date}##{lastMsg.Sender}##{lastMsg.Receiver}##{censored}##{lastMsg.IsRead}");
            }
            else
            {
                Console.WriteLine($"No messages received by {receiver.Name}.");
            }

        }
        public List<Message> GetAllMessagesForPerson(Person person)
        {
            return messages
                .Where(m => m.Sender.Id == person.Id || m.Receiver.Id == person.Id)
                .OrderBy(m => m.Date)
                .ToList();
        }
        public void MessagesDay()
        {
            var groups = messages.GroupBy(m =>
            {
                var hour = m.Date.Hour;
                if (hour >= 5 && hour < 12)
                    return "Morning";
                else if (hour >= 12 && hour < 17)
                    return "Afternoon";
                else if (hour >= 17 && hour < 21)
                    return "Evening";
                else
                    return "Night";
            });

            foreach (var group in groups)
            {
                Console.WriteLine($" {group.Key} ");
                foreach (var message in group.OrderBy(m => m.Date))
                {
                    Console.WriteLine(message);
                }
            }
        }
        public void SearchMessages(Person person, string keyword)
        {
            var matched = messages
                .Where(m =>
                    (m.Sender.Id == person.Id || m.Receiver.Id == person.Id) &&
                    m.Content.IndexOf(keyword, StringComparison.OrdinalIgnoreCase) >= 0)
                .OrderBy(m => m.Date);

            Console.WriteLine($"Messages for {person.Name} containing '{keyword}':");
            foreach (var msg in matched)
                Console.WriteLine(msg);
        }
        public List<PersonCorrespondents> GetCorrespondents()
        {
            var result = persons.Select(p => new PersonCorrespondents
            {
                Person = p,
                Correspondents = messages
                    .Where(m => m.Sender.Id == p.Id || m.Receiver.Id == p.Id)
                    .Select(m => m.Sender.Id == p.Id ? m.Receiver : m.Sender)
                    .Distinct()
                    .ToList()
            }).ToList();

            return result;
        }

        public void PrintCorrespondents()
        {
            var correspondentsList = GetCorrespondents();

            foreach (var entry in correspondentsList)
            {
                Console.WriteLine($"Person: {entry.Person}");
                Console.WriteLine("Correspondents:");
                foreach (var c in entry.Correspondents)
                    Console.WriteLine($"  - {c}");
                Console.WriteLine();
            }
        }
    }
}
