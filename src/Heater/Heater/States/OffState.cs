namespace Heater.States
{
    public sealed class OffState : IState
    {
        public string GetText()
        {
            return "Low";
        }

        public void UpState(Context context)
        {
            // Lowにしたい
            context.ChangeState(new LowState());
        }
    }
}
