namespace DDD.Objects
{
    public sealed class DecoratorLower : IComponent
    {
        private IComponent _child;

        public DecoratorLower(IComponent child)
        {
            _child = child;
        }

        public string GetData()
        {
            return _child.GetData().ToLower();
        }
    }
}
