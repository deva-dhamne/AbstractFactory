namespace AbstractFactory
{
    public class WindowsFactory : IGUIFactory
    {
        public IButton CreateButton() => new WindowsButton();
        public ICheckbox CreateCheckbox() => new WindowsCheckbox();
    }
}
