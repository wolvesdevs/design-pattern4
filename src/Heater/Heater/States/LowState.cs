namespace Heater.States
{
    public sealed class LowState : IState
    {
        public void UpState(Context context)
        {
            // Hiにしたい
            context.ChangeState(new HighState());
        }
    }
}
