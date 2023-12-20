namespace Heater.States
{
    public sealed class LowState : IState
    {
        private LowState() { }
        public static LowState Instance { get; } = new LowState();

        public IEnumerable<string> GetCommand()
        {
            return new List<string> { "Low", "500W" };
        }

        public string GetText()
        {
            return "Low";
        }

        public void UpState(Context context)
        {
            // Hiにしたい
            context.ChangeState(MiddleState.Instance);
        }

        public void DownState(Context context)
        {
            // OFFにしたい
            context.ChangeState(HighState.Instance);
        }

        public void OnOffState(Context context)
        {
            context.ChangeState(OffState.Instance);
        }
    }
}
