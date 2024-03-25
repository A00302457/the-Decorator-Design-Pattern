namespace Design_Pattern
{
    public class PlainDecorator : Decorator<string>
    {
        string? _prefix = "Hello, Pooja! How are you doing today? ";
        public PlainDecorator(IComponent<string> icomponent, string prefix) : base(icomponent)
        {
            _prefix = prefix;
        }

        public override string GetText()
        {
            return _prefix + base.GetText();            
        }
    }
}