namespace DDD.Objects
{
    public sealed class DecoratorUpper : Decorator
    {
        public DecoratorUpper(IComponent child) : base(child)
        {
        }

        protected override string GetDataSub()
        {
            return _child.GetData().ToUpper();
        }
    }
}
