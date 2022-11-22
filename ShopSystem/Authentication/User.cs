namespace ShopSystem.Authentication
{
    public class User
    {
        private string Username;
        private string Hash, Salt;
        private Role Role;

        public User(string username, Role role, string hash, string salt)
        {
            this.Username = username;
            this.Role = role;

            this.Hash = hash;
            this.Salt = salt;
        }

        public string Serialize()
        {
            return string.Join(":", new string[] { Username, Convert.ToString((int)Role), Hash, Salt }); 
        }

        public static User? Deserialize(string data)
        {
            string[] split = data.Split(":");
            return new User(split[0], Enum.Parse<Role>(split[1]), split[2], split[3]);
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
