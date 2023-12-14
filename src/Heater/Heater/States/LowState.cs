namespace Heater.States
{
    public sealed class LowState : IState
    {
        public string GetText()
        {
            return "OFF";
        }

        public void UpState(Context context)
        {
            // Hiにしたい
            context.ChangeState(new HighState());
        }
    }
}
