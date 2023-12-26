
namespace DDDCom.Messages
{
    public sealed class MessageDecoratorZip : MessageDecorator
    {
        public MessageDecoratorZip(IMessage child) : base(child)
        {
        }

        public override IEnumerable<byte> GetBytes()
        {
            var result = new List<byte>();
            int index = 0;

            foreach (var val in _child.GetBytes())
            {
                if (index % 2 == 0)
                {
                    result.Add(val);
                }

                index++;
            }

            return result;
        }
    }
}
