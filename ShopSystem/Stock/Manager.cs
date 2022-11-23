namespace ShopSystem.Stock
{
    public class Manager
    {
        private string path = Program.storageDirectory + "/stock.bin";
        private List<Product> products = new();

        public Manager()
        {
            if (!File.Exists(path))
                return;

            foreach (string line in File.ReadAllLines(path))
            {
                var product = Product.Deserialize(line);
                if (product == null) return;

                products.Add(product);
            }
        }

        public Product? AddProduct(string name, int quantity, string image = "")
        {
            var exists = products.Find(product => product.GetName().ToLower() == name.ToLower());
            if (exists != null) return null;

            var product = new Product(name, quantity, image);
            products.Add(product);

            File.AppendAllText(path, product.Serialize() + Environment.NewLine);
            return product;
        }

        public void RemoveProduct(string name)
        {
            var product = products.Find(product => product.GetName() == name);
            if (product == null) return;
            products.Remove(product);

            SaveProducts();
        }

        public Product? GetProduct(string name)
        {
            return products.Find(product => product.GetName().ToLower() == name.ToLower());
        }

        public void SaveProducts()
        {
            var serialized = new List<string>();
            products.ForEach(product => serialized.Add(product.Serialize()));
            File.WriteAllLines(path, serialized);
        }

        public List<Product> GetProducts()
        {
            return products;
        }
    }
}
