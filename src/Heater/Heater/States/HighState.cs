namespace Heater.States
{
    public sealed class HighState : IState
    {
        private HighState() { }
        public static HighState Instance { get; } = new HighState();

        public IEnumerable<string> GetCommand()
        {
            return new List<string> { "High", "1000W" };
        }

        public string GetText()
        {
            return "High";
        }

        public void UpState(Context context)
        {
            // Lowにしたい
            context.ChangeState(LowState.Instance);
        }

        public void DownState(Context context)
        {
            // Midにしたい
            context.ChangeState(MiddleState.Instance);
        }

        public void OnOffState(Context context)
        {
            context.ChangeState(OffState.Instance);
        }
    }
}
