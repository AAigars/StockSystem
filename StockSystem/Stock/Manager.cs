namespace StockSystem.Stock
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
            var exists = GetProduct(name);
            if (exists != null) return null;

            // save a copy of the image in the storage directory
            if (image != string.Empty && image != null)
            {
                var file = image.Split("\\").Last();
                File.Copy(image, Program.imageDirectory + "\\" + file, true);
                image = file;
            }

            var product = new Product(name, quantity, image);
            products.Add(product);

            File.AppendAllText(path, product.Serialize() + Environment.NewLine);
            return product;
        }

        public void RemoveProduct(string name)
        {
            var product = GetProduct(name);
            if (product == null) return;
            
            /*
             * remove image copy if exists
             * cant get it to work as the image is in use by the process apparently
             
               var image = product.GetImage();
               if (image != null && image != string.Empty)
                   File.Delete(image);
            */

            products.Remove(product);
            SaveProducts();
        }

        public void SaveProducts()
        {
            var serialized = new List<string>();
            products.ForEach(product => serialized.Add(product.Serialize()));

            File.WriteAllLines(path, serialized);
        }

        public Product? GetProduct(string name)
        {
            return products.Find(product => product.GetName().ToLower() == name.ToLower());
        }

        public List<Product> GetProducts()
        {
            return products;
        }
    }
}
