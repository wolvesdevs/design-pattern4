
namespace DDDCom.Messages
{
    public sealed class MessageDecoratorXOR : MessageDecorator
    {
        public MessageDecoratorXOR(IMessage child) : base(child)
        {
        }

        public override IEnumerable<byte> GetBytes()
        {
            var result = new List<byte>();

            foreach (var val in _child.GetBytes())
            {
                result.Add(Convert.ToByte(val ^ 123));
            }

            return result;
        }
    }
}
