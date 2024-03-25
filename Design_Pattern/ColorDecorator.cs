namespace Design_Pattern
{
    public class ColorDecorator : Decorator<string>
    {
        public ColorDecorator(IComponent<string> icomponent) : base(icomponent)
        {
        }

        public override string GetText()
        {
            //return base.GetText() + $"\u001b[31m{base.GetText()}\u001b[0m";
            return  $"\u001b[31m{base.GetText()}\u001b[0m";
        }
    }
}