namespace Heater.States
{
    public sealed class OffState : IState
    {
        public IEnumerable<string> GetCommand()
        {
            return new List<string> { "OFF", "0W" };
        }

        public string GetText()
        {
            return "OFF";
        }

        public void UpState(Context context)
        {
            // Lowにしたい
            context.ChangeState(new LowState());
        }
    }
}
