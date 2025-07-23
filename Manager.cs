using registerApp;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace registerApp
{
    public class Manager
    {
        private const string FilePath = "users.txt";
        public List<User> Users { get; private set; } = new List<User>();

        public void LoadFromFile()
        {
            if (!File.Exists(FilePath))
                return;

            var lines = File.ReadAllLines(FilePath);
            foreach (var line in lines)
            {
                Users.Add(User.FromString(line));
            }
        }

        public void SaveToFile()
        {
            var lines = Users.Select(u => u.ToString()).ToArray();
            File.WriteAllLines(FilePath, lines);
        }
        public int GenerateNewId()
        {
            return Users.Count == 0 ? 1 : Users.Max(u => u.ID) + 1;
        }

    }
}
