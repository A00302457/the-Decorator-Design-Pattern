namespace Design_Pattern
{
    public abstract class Decorator<T> : IComponent<T>
    {
        protected IComponent<T> _icomponent;

        public Decorator(IComponent<T> icomponent)
        {
            _icomponent = icomponent;
        }

        public virtual T GetText()
        {
            return _icomponent.GetText();
        }
    }
}
