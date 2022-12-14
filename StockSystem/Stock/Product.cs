using System.Reflection;
using System.Web;

namespace StockSystem.Stock
{
    public class Product
    {
        private string name;
        private int quantity;
        private string? image;

        public Product(string name, int quantity)
        {
            this.name = name;
            this.quantity = quantity;
            this.image = null;
        }

        public Product(string name, int quantity, string image)
        {
            this.name = name;
            this.quantity = quantity;
            this.image = image;
        }

        public string Serialize()
        {
            var data = new List<string>() { name, quantity.ToString() };

            // image path is encoded, so special characters do not intefere when deserializing
            if (image != null) data.Add(HttpUtility.UrlEncode(image));

            return string.Join(":", data);
        }

        public static Product? Deserialize(string data)
        {
            string[] split = data.Split(":");
            if (split.Length == 3) // product supports an image
            {
                // image path is decoded, as it is encoded to prevent special characters from intefering when deserializing
                return new Product(split[0], Convert.ToInt32(split[1]), HttpUtility.UrlDecode(split[2]));
            }
            else
            {
                return new Product(split[0], Convert.ToInt32(split[1]));
            }
        }

        public string GetName()
        {
            return name;
        }

        public int GetQuantity()
        {
            return quantity;
        }

        public string? GetImage()
        {
            if (image != null && image != string.Empty)
                return Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + Program.imageDirectory + "\\" + image;
            return null;
        }

        public void SetName(string name)
        {
            this.name = name;
        }

        public void SetQuantity(int quantity)
        {
            this.quantity = quantity;
        }

        public void SetImage(string image)
        {
            this.image = image;
        }
    }
}
