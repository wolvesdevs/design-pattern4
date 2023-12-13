namespace Heater.States
{
    public sealed class HighState : IState
    {
        public void UpState(Context context)
        {
            // OFFにしたい
            context.ChangeState(new OffState());
        }
    }
}
