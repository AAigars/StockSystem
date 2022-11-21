namespace ShopSystem
{
    internal static class Program
    {
        /// <summary>
        /// Static variables.
        /// </summary>
        public static string title = "Stock System";
        public static string storageDirectory = "./data";

        public static Authentication.Manager authManager = new();
        public static Stock.Manager stockManager = new();

        public static LoginForm? loginForm;

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Create directory for the Application Data.
            if (!Directory.Exists(storageDirectory))
            {
                Directory.CreateDirectory(storageDirectory);
            }

            // Form entry point.
            ApplicationConfiguration.Initialize();

            loginForm = new();            
            Application.Run(loginForm);
        }
    }
}