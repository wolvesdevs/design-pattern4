namespace Heater.States
{
    public sealed class HighState : IState
    {
        public string GetText()
        {
            return "High";
        }

        public void UpState(Context context)
        {
            // OFFにしたい
            context.ChangeState(new OffState());
        }
    }
}
