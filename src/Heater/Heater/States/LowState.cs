namespace Heater.States
{
    public sealed class LowState : IState
    {
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
