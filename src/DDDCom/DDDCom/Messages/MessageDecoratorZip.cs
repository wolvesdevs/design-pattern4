
namespace DDDCom.Messages
{
    public sealed class MessageDecoratorZip : IMessage
    {
        private IMessage _child;

        public MessageDecoratorZip(IMessage child)
        {
            _child = child;
        }

        public IEnumerable<byte> GetBytes()
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
