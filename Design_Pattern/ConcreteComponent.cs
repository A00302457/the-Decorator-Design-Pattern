namespace Design_Pattern
{
    public class ConcreteComponent : IComponent<string>
    {     
        public string GetText()
        {
            return "Hello, Pooja! How are you doing today?";
        }
     
    }
}
