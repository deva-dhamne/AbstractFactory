namespace AbstractFactory
{
    public class Program
    {
        public static void Main()
        {
            IGUIFactory factory;

            factory = new WindowsFactory();
            IButton windowsButton = factory.CreateButton();
            ICheckbox windowsCheckbox = factory.CreateCheckbox();
            windowsButton.Render();  
            windowsCheckbox.Render();  

            factory = new MacFactory();
            IButton macButton = factory.CreateButton();
            ICheckbox macCheckbox = factory.CreateCheckbox();
            macButton.Render();  
            macCheckbox.Render();  
        }
    }
}
