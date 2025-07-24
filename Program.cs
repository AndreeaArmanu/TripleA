using System;

namespace PracticeProblem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Manager manager = new Manager();

            manager.PrintUniquePersons();

            Person john = manager.getPerson(101);
            Person jane = manager.getPerson(201);
            Person diana = manager.getPerson(203);

            manager.CountMessagesBetween(john, jane);
            manager.PrintMessagesBetween(john, jane);

            manager.PrintDate(new DateTime(2024, 6, 10));
            manager.PrintMessagesFromSender(john);

            manager.SaveConversation(john, jane, "John_Jane_Conversation.txt");

            manager.PrintUnseenMessages();
            manager.PrintLastMessage(jane, "John");

            var johnMessages = manager.GetAllMessagesForPerson(john);
            Console.WriteLine($"All messages for {john.Name}:");
            johnMessages.ForEach(Console.WriteLine);

            Console.WriteLine("\nGrouped messages by time of day:");
            manager.MessagesDay();

            Console.WriteLine("\nSearch 'project' in Jane's messages:");
            manager.SearchMessages(jane, "project");

            Console.WriteLine("\nCorrespondents for each person:");
            manager.PrintCorrespondents();


        }
    }
}

