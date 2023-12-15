namespace Heater.States
{
    public sealed class LowState : IState
    {
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
            context.ChangeState(new HighState());
        }
    }
}
