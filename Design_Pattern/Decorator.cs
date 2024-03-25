namespace Design_Pattern
{
    public abstract class Decorator<T> : IComponent<T>
    {
        protected IComponent<T> _component;

        public Decorator(IComponent<T> component)
        {
            _component = component;
        }

        public T GetText()
        {
            return _component.GetText();
        }
    }
}
