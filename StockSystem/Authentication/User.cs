namespace StockSystem.Authentication
{
    public class User
    {
        private string firstName, lastName;
        private string username;
        private string hash, salt;
        private Role role;

        public User(string firstName, string lastName, string username, Role role, string hash, string salt)
        {
            this.firstName = firstName;
            this.lastName = lastName;

            this.username = username;
            this.role = role;

            this.hash = hash;
            this.salt = salt;
        }

        public string Serialize()
        {
            return string.Join(":", new string[] { firstName, lastName, username, Convert.ToString((int)role), hash, salt });
        }

        public static User? Deserialize(string data)
        {
            string[] split = data.Split(":");
            return new User(split[0], split[1], split[2], Enum.Parse<Role>(split[3]), split[4], split[5]);
        }

        public string GetFirstName()
        {
            return firstName;
        }

        public string GetLastName()
        {
            return lastName;
        }

        public string GetUsername()
        {
            return username;
        }

        public Role GetRole()
        {
            return role;
        }

        public string GetHash()
        {
            return hash;
        }

        public string GetSalt()
        {
            return salt;
        }

        public void SetFirstName(string firstName)
        {
            this.firstName = firstName;
        }

        public void SetLastName(string lastName)
        {
            this.lastName = lastName;
        }

        public void SetRole(Role role)
        {
            this.role = role;
        }

        public void SetPassword(string password)
        {
            salt = Utility.Security.GenerateSalt();
            hash = Utility.Security.HashPassword(password, salt);
        }

        public void SetSalt(string salt)
        {
            this.salt = salt;
        }

        public void SetHash(string hash)
        {
            this.hash = hash;
        }
    }
}
