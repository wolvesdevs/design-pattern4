namespace DDDCom.Messages
{
    public interface IMessage
    {
        IEnumerable<byte> GetBytes();
    }
}
