namespace Heater.States
{
    public sealed class HighState : IState
    {
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
            context.ChangeState(new LowState());
        }

        public void DownState(Context context)
        {
            // Midにしたい
            context.ChangeState(new MiddleState());
        }

        public void OnOffState(Context context)
        {
            context.ChangeState(new OffState());
        }
    }
}
