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
        }

        public Product(string name, int quantity, string image)
        {
            Name = name;
            Quantity = quantity;
            Image = image;
        }

        public string Serialize()
        {
            return string.Format("{0}:{1}", Name, Quantity);
        }

        public static Product? Deserialize(string data)
        {
            string[] split = data.Split(":");
            return new Product(split[0], Convert.ToInt32(split[1]));
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
    }
}
