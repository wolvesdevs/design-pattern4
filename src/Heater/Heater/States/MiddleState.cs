namespace Heater.States
{
    internal sealed class MiddleState : IState
    {
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
            context.ChangeState(new HighState());
        }

        public void DownState(Context context)
        {
            // Lowにしたい
            context.ChangeState(new LowState());
        }

        public void OnOffState(Context context)
        {
            context.ChangeState(new OffState());
        }
    }
}
