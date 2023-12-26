
namespace DDDCom.Messages
{
    public abstract class MessageDecorator : IMessage
    {
        protected IMessage _child;

        public MessageDecorator(IMessage child)
        {
            _child = child;
        }

        public abstract IEnumerable<byte> GetBytes();
    }
}
