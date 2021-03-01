namespace UnitTestPractice
{
    public class ExtensionMangerFactory
    {
        private static IExtensionManager customerManager = null;
        public static IExtensionManager Create() 
        {
            if (customerManager != null) 
            {
                return customerManager;
            }
            return new FileExtensionmanager();
        }

        public static void SetManager(IExtensionManager manager)
        {
            customerManager = manager;
        }
    }
}