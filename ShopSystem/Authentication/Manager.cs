﻿namespace ShopSystem.Authentication
{
    public class Manager
    {
        private string path = Program.storageDirectory + "/users.bin";
        private List<User> users = new();

        public Manager()
        {
            if (!File.Exists(path))
                return;

            foreach (string line in File.ReadAllLines(path))
            {
                var user = User.Deserialize(line);
                if (user == null) return;

                users.Add(user);
            }
        }

        public User? CreateUser(string username, string password, Role role = Role.Customer)
        {
            var exists = users.Find(user => user.GetUsername() == username);
            if (exists != null) return null;

            var salt = Utility.Security.GenerateSalt();
            var hash = Utility.Security.HashPassword(password, salt);

            var user = new User(username, role, hash, salt);
            users.Add(user);

            File.AppendAllText(path, user.Serialize() + Environment.NewLine);
            return user;
        }

        public User? AuthUser(string username, string password)
        {
            var user = users.Find(user => user.GetUsername() == username);
            if (user == null) return null;

            var hash = Utility.Security.HashPassword(password, user.GetSalt());
            return hash == user.GetHash() ? user : null;
        }
    }
}
