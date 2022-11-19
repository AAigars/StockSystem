namespace ShopSystem.Authentication
{
    public class User
    {
        private string username;
        private string hash, salt;
        private Role role;

        public User(string username, Role role, string hash, string salt)
        {
            this.username = username;
            this.role = role;

            this.hash = hash;
            this.salt = salt;
        }

        public string Serialize()
        {
            return string.Format("{0}:{1}:{2}:{3}", username, (int)role, hash, salt);
        }

        public static User? Deserialize(string data)
        {
            string[] split = data.Split(":");
            return new User(split[0], Enum.Parse<Role>(split[1]), split[2], split[3]);
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
    }
}
