using ShopSystem.Stock;

namespace ShopSystem.Authentication
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

        public User? CreateUser(string firstName, string lastName, string username, string password, Role role = Role.Employee)
        {
            var exists = users.Find(user => user.GetUsername() == username);
            if (exists != null) return null;

            var salt = Utility.Security.GenerateSalt();
            var hash = Utility.Security.HashPassword(password, salt);

            var user = new User(firstName, lastName, username, role, hash, salt);
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

        public void SaveUsers()
        {
            var serialized = new List<string>();
            users.ForEach(user => serialized.Add(user.Serialize()));

            File.WriteAllLines(path, serialized);
        }

        public void RemoveUser(string name)
        {
            var user = GetUser(name);
            if (user == null) return;

            users.Remove(user);
            SaveUsers();
        }

        public List<User> GetUsers()
        {
            return users;
        }

        public User? GetUser(string username)
        {
            return users.Find(user => user.GetUsername() == username);
        }
    }
}
