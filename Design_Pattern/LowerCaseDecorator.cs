namespace Design_Pattern
{
    public class LowerCaseDecorator : Decorator<string>
    {
        public LowerCaseDecorator(IComponent<string> icomponent) : base(icomponent)
        {
        }

        public override string GetText()
        {
            return base.GetText().ToLower();
        }
    }
}