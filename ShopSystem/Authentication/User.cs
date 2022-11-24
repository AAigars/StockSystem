namespace ShopSystem.Authentication
{
    public class User
    {
        private string FirstName, LastName;
        private string Username;
        private string Hash, Salt;
        private Role Role;

        public User(string firstName, string lastName, string username, Role role, string hash, string salt)
        {
            this.FirstName = firstName;
            this.LastName = lastName;   

            this.Username = username;
            this.Role = role;

            this.Hash = hash;
            this.Salt = salt;
        }

        public string Serialize()
        {
            return string.Join(":", new string[] { FirstName, LastName, Username, Convert.ToString((int)Role), Hash, Salt }); 
        }

        public static User? Deserialize(string data)
        {
            string[] split = data.Split(":");
            return new User(split[0], split[1], split[2], Enum.Parse<Role>(split[3]), split[4], split[5]);
        }

        public string GetFirstName()
        {
            return FirstName;
        }

        public string GetLastName()
        {
            return LastName;
        }

        public string GetUsername()
        {
            return Username;
        }

        public Role GetRole()
        {
            return Role;
        }

        public string GetHash()
        {
            return Hash;
        }

        public string GetSalt()
        {
            return Salt;
        }
    }
}
