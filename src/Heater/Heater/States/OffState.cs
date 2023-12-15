namespace Heater.States
{
    public sealed class OffState : IState
    {
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
