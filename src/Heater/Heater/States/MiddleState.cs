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
            // OFFにしたい
            context.ChangeState(new HighState());
        }
    }
}
