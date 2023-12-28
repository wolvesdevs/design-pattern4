
namespace DDDCom.Messages
{
    public sealed class MeasureMessage : IMessage
    {
        public MeasureMessage(int measureId)
        {
            MeasureId = measureId;
        }

        public int CommandId => 100;
        public int MeasureId { get; }

        public IEnumerable<byte> GetBytes()
        {
            var result = new List<byte>();
            result.AddRange(BitConverter.GetBytes(CommandId));
            result.AddRange(BitConverter.GetBytes(MeasureId));
            return result;
        }
    }
}
