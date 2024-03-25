namespace Design_Pattern
{
    public class UpperCaseDecorator : Decorator<string>
    {
        public UpperCaseDecorator(IComponent<string> icomponent) : base(icomponent)
        {
        }

        public override string GetText()
        {
            return base.GetText().ToUpper();
        }
    }
}