namespace ShopSystem
{
    internal static class Program
    {
        /// <summary>
        /// Static variables.
        /// </summary>
        public static string storageDirectory = "./data";
        public static Authentication.Manager authManager = new Authentication.Manager();

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Create directory for Shop System Data.
            if (!Directory.Exists(storageDirectory))
            {
                Directory.CreateDirectory(storageDirectory);
            }

            // Form entry point.
            ApplicationConfiguration.Initialize();
            Application.Run(new LoginForm());
        }
    }
}