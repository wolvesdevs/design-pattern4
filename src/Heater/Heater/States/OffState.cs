namespace Heater.States
{
    public sealed class OffState : IState
    {
        public void UpState(Context context)
        {
            // Lowにしたい
            context.ChangeState(new LowState());
        }
    }
}
