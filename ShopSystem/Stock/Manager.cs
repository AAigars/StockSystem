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

        public Product AddProduct(string name, int quantity, string image = "")
        {
            var product = new Product(name, quantity, image);
            products.Add(product);

            File.AppendAllText(path, product.Serialize() + Environment.NewLine);
            return product;
        }

        public void RemoveProduct()
        {
            // TODO: 
        }

        public List<Product> GetProducts()
        {
            return products;
        }
    }
}
