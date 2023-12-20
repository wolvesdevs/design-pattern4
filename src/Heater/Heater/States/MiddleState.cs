namespace Heater.States
{
    internal sealed class MiddleState : IState
    {
        private MiddleState() { }
        public static MiddleState Instance { get; } = new MiddleState();

        public IEnumerable<string> GetCommand()
        {
            return new List<string> { "Mid", "700W" };
        }

        public string GetText()
        {
            return "Mid";
        }

        public void UpState(Context context)
        {
            // Highにしたい
            context.ChangeState(HighState.Instance);
        }

        public void DownState(Context context)
        {
            // Lowにしたい
            context.ChangeState(LowState.Instance);
        }

        public void OnOffState(Context context)
        {
            context.ChangeState(OffState.Instance);
        }
    }
}
