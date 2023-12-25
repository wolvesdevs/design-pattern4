namespace DDD.Objects
{
    public sealed class DecoratorLower : Decorator
    {
        public DecoratorLower(IComponent child) : base(child)
        {
        }

        protected override string GetDataSub()
        {
            return _child.GetData().ToLower();
        }

        protected override int GetPriceSub()
        {
            return 30;
        }
    }
}
