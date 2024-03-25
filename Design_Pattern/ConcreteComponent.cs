namespace Design_Pattern
{
    public class ConcreteComponent : IComponent<string>
    {     
        public string GetText()
        {
            return "I hope you doing good today! ";
        }
     
    }
}
