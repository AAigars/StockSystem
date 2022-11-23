using System.Web;

namespace ShopSystem.Stock
{
    public class Product
    {
        private string Name;
        private int Quantity;
        private string? Image;

        public Product(string name, int quantity)
        {
            Name = name;
            Quantity = quantity;    
            Image = null;
        }

        public Product(string name, int quantity, string image)
        {
            Name = name;
            Quantity = quantity;
            Image = image;
        }

        public string Serialize()
        {
            // image path is encoded, so special characters do not intefere when deserializing
            var data = new List<string>() { Name, Quantity.ToString() };
            if (Image != null) 
                data.Add(HttpUtility.UrlEncode(Image));

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
            return Name;
        }

        public int GetQuantity()
        {
            return Quantity;
        }

        public string? GetImage()
        {
            return Image;
        }

        public void SetName(string name)
        {
            Name = name;
        }

        public void SetQuantity(int quantity)
        {
            Quantity = quantity;
        }

        public void SetImage(string image)
        {
            Image = image;
        }
    }
}
