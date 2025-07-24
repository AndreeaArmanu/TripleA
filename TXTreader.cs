using System;
using System.Collections.Generic;
using System.IO;

namespace PracticeProblem
{
    internal class TXTreader
    {
        public static List<Message> ReadMessagesTXT(string path)
        {
            List<Message> messages = new List<Message>();
            Dictionary<int, Person> persons = new Dictionary<int, Person>();

            foreach (string line in File.ReadAllLines(path))
            {
                string[] parts = line.Split(new string[] { "##" }, StringSplitOptions.None);

                DateTime date = DateTime.Parse(parts[0]);
                Person sender = ParsePerson(parts[1], persons);
                Person receiver = ParsePerson(parts[2], persons);
                string content = parts[3];
                bool isRead = bool.Parse(parts[4]);

                messages.Add(new Message
                {
                    Date = date,
                    Sender = sender,
                    Receiver = receiver,
                    Content = content,
                    IsRead = isRead
                });
            }

            return messages;
        }

        private static Person ParsePerson(string input, Dictionary<int, Person> persons)
        {
            int openParen = input.IndexOf('(');
            int closeParen = input.IndexOf(')');
            string name = input.Substring(0, openParen).Trim();
            string inside = input.Substring(openParen + 1, closeParen - openParen - 1);
            string[] parts = inside.Split(',');

            int id = int.Parse(parts[0]);
            string email = parts[1];
            int age = parts.Length == 3 ? int.Parse(parts[2]) : 0;

            if (!persons.ContainsKey(id))
            {
                persons[id] = new Person
                {
                    Id = id,
                    Name = name,
                    Email = email,
                    Age = age
                };
            }

            return persons[id];
        }
    }
}