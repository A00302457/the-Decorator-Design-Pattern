namespace Design_Pattern
{
    public class BackgroundColorDecorator : Decorator<string>
    {
        public BackgroundColorDecorator(IComponent<string> icomponent) : base(icomponent)
        {
        }

        public override string GetText()
        {
            return $"\u001b[41m{base.GetText()}\u001b[0m";
        }
    }
}